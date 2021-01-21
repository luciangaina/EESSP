using EESSP.Contexts;
using EESSP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EESSP
{
    public partial class Form4 : Form
    {
        private ProjectContext _dbContext = new ProjectContext();
        private Pacient pacient;
        private Screen screen;
        private MainApp parentForm;
        private Consultatie consultatie;
        public string codDiagnosticResult;

        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Pacient pacient, Screen screen)
        {
            InitializeComponent();
            this.pacient = pacient;
            this.screen = screen;
        }

        public Form4(Consultatie consultatie, Screen screen)
        {
            InitializeComponent();
            this.consultatie = consultatie;
            this.screen = screen;
        }

        public Form4(MainApp parentForm, Consultatie consultatie, Screen screen)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.consultatie = consultatie;
            this.screen = screen;
        }

        private void Form4_onLoad(object sender, EventArgs e)
        {
            if (screen == Screen.AdaugaConsultatieCnp)
            {
                panelAdaugareConsultatie.BringToFront();
                textBoxCNP.Text = pacient.CNP;
                textBoxPacient.Text = pacient.Nume.Trim() + " " + pacient.Prenume.Trim();
                textBoxCNP.ReadOnly = true;
                textBoxPacient.ReadOnly = true;
            }
            else if (screen == Screen.VizualizareConsultatie)
            {
                panelVizualizareConsultatie.BringToFront();
                textBoxCnpConsultatie.Text = consultatie.CnpPacient;
                var pacientConsultatie = _dbContext.Pacient.Where(pacient => pacient.CNP.Equals(consultatie.CnpPacient)).FirstOrDefault();
                textBoxPacientConsultatie.Text = pacientConsultatie.Nume.Trim() + " " + pacientConsultatie.Prenume.Trim();
                textBoxDataConsultatie.Text = consultatie.DataConsultatie.ToString("d");
            }
            else if (screen == Screen.ModificaConsultatie)
            {
                panelModificaConsultatie.BringToFront();
                textBoxCnpModificare.Text = consultatie.CnpPacient;
                var pacientConsultatie = _dbContext.Pacient.Where(pacient => pacient.CNP.Equals(consultatie.CnpPacient)).FirstOrDefault();
                textBoxPacientModificare.Text = pacientConsultatie.Nume.Trim() + " " + pacientConsultatie.Prenume.Trim();
                dateTimePickerModificareConsultatie.Value = consultatie.DataConsultatie;
            }
        }

        private void buttonAdaugaConsultatie_Click(object sender, EventArgs e)
        {
            var newConsultatie = new Consultatie()
            {
                CnpPacient = textBoxCNP.Text,
                DataConsultatie = datePickerDataConsultatie.Value,
                EsteSters = false,
                EsteFinalizata = false
            };

            _dbContext.Consultatie.Add(newConsultatie);
            _dbContext.SaveChanges();
            var response = MessageBox.Show("Consultatia a fost introdusa in sistem.", "", MessageBoxButtons.OK);
            if (response == DialogResult.OK)
            {
                if (parentForm != null)
                    parentForm.refreshPatientsList();
                this.Close();
            }
        }

        private void buttonSelectDiagnostic_Click(object sender, EventArgs e)
        {
            Form5 listaDiagnostice = new Form5(this);
            listaDiagnostice.ShowDialog();

            textBoxCodDiagnostic.Text = codDiagnosticResult;
            var diagnostic = _dbContext.Diagnostic.Where(diagnostic => diagnostic.CodDiagnostic.Equals(codDiagnosticResult)).FirstOrDefault();
            textBoxNumeDiagnostic.Text = diagnostic.NumeDiagnostic;
        }

        private void textBoxCodDiagnostic_Leave(object sender, EventArgs e)
        {
            var codDiagnostic = textBoxCodDiagnostic.Text;
            var diagnostic = _dbContext.Diagnostic.Where(diagnostic => diagnostic.CodDiagnostic.Equals(codDiagnostic)).FirstOrDefault();
            if (diagnostic == default)
            {
                MessageBox.Show("Diagnosticul nu exista in baza de date.\nConsultati lista de diagnostice!", "Eroare", MessageBoxButtons.OK);
                textBoxCodDiagnostic.Clear();
            }
            else
                textBoxNumeDiagnostic.Text = diagnostic.NumeDiagnostic;
        }

        private void buttonSalveazaConsultatie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCnpConsultatie.Text) || string.IsNullOrEmpty(textBoxDataConsultatie.Text) || string.IsNullOrEmpty(textBoxCodDiagnostic.Text))
                MessageBox.Show("Campurile obligatorii nu sunt completate!", "Eroare", MessageBoxButtons.OK);
            else
            {
                consultatie.CodDiagnostic = textBoxCodDiagnostic.Text;
                consultatie.Medicatie = textBoxMedicatie.Text;
                consultatie.Recoamndari = textBoxRecomandari.Text;
                consultatie.EsteFinalizata = true;

                _dbContext.Update(consultatie);
                _dbContext.SaveChangesAsync();
                var response = MessageBox.Show("Consultatia pentru a fost actualizata.", "", MessageBoxButtons.OK);
                if (response == DialogResult.OK)
                {
                    this.Close();
                    parentForm.refreshConsultatiiList();
                }
            }
        }

        private void buttonSalveazaModificari_Click(object sender, EventArgs e)
        {
            consultatie.DataConsultatie = dateTimePickerModificareConsultatie.Value;
            _dbContext.Update(consultatie);
            _dbContext.SaveChanges();
            var response = MessageBox.Show("Data consultatiei a fost modificata", "", MessageBoxButtons.OK);
            if (response == DialogResult.OK)
            {
                parentForm.refreshConsultatiiList();
                this.Close();
            }
        }
    }
}
