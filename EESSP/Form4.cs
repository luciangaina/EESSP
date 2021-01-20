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
            else if(screen==Screen.VizualizareConsultatie)
            {
                panelVizualizareConsultatie.BringToFront();
                textBoxCnpConsultatie.Text = consultatie.CnpPacient;
                var pacientConsultatie = _dbContext.Pacient.Where(pacient => pacient.CNP.Equals(consultatie.CnpPacient)).FirstOrDefault();
                textBoxPacientConsultatie.Text= pacientConsultatie.Nume.Trim() + " " + pacientConsultatie.Prenume.Trim();
                textBoxDataConsultatie.Text = consultatie.DataConsultatie.ToString("d");
            }
        }

        private void buttonAdaugaConsultatie_Click(object sender, EventArgs e)
        {
            var newConsultatie = new Consultatie()
            {
                CnpPacient = textBoxCNP.Text,
                DataConsultatie = datePickerDataConsultatie.Value,
                EsteSters = false
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
            Form5 listaDiagnostice = new Form5();
            listaDiagnostice.Show();
        }
    }
}
