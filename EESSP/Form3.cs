using EESSP.Contexts;
using EESSP.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form3 : Form
    {
        private ProjectContext _dbContext = new ProjectContext();
        private MainApp parentForm;
        private Pacient pacient;
        private Screen screen;

        public Form3(MainApp parentForm, Pacient pacient, Screen screen)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.pacient = pacient;
            this.screen = screen;
        }

        public Form3(Pacient pacient, Screen screen)
        {
            InitializeComponent();
            this.pacient = pacient;
            this.screen = screen;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_onLoad(object sender, EventArgs e)
        {
            if (pacient != null && screen == Screen.ModificaPacient)
            {
                panelEditPacient.BringToFront();
                textBoxEditCNP.Text = pacient.CNP;
                textBoxEditNrFisa.Text = pacient.NrFisa.Trim();
                textBoxEditGen.Text = pacient.Gen.Trim();
                textBoxEditNume.Text = pacient.Nume.Trim();
                textBoxEditPrenume.Text = pacient.Prenume.Trim();
                dateTimePickerEdit.Value = pacient.DataNastere;
                textBoxEditVarsta.Text = pacient.Varsta.ToString().Trim();
                checkBoxEdit.Checked = pacient.Asigurare;
                textBoxEditTelefon.Text = pacient.Telefon.Trim();
                textBoxEditLocalitate.Text = pacient.Localitate.Trim();
                textBoxEditJudet.Text = pacient.Judet.Trim();
                textBoxEditStrada.Text = pacient.Strada.Trim();
                textBoxEditNumar.Text = pacient.Numar.Trim();
                textBoxEditBloc.Text = pacient.Bloc.Trim();
                textBoxEditScara.Text = pacient.Scara;
                textBoxEditApartament.Text = pacient.Apartament.Trim();
                comboBoxEditGrupaSg.Text = pacient.GrupaSg.Trim();
                comboBoxEditRh.Text = pacient.Rh.Trim();
                textBoxEditGreutate.Text = pacient.Greutate.ToString();
                textBoxEditInaltime.Text = pacient.Inaltime.ToString();
            }
            if (pacient != null && screen == Screen.FisaPacient)
            {
                panelFisaPacient.BringToFront();
                labelCNP.Text = pacient.CNP;
                labelNrFisa.Text = pacient.NrFisa;
                labelGender.Text = pacient.Gen;
                labelNume.Text = pacient.Nume;
                labelPrenume.Text = pacient.Prenume;
                labelDataNastere.Text = pacient.DataNastere.ToString("d");
                labelVarsta.Text = pacient.Varsta.ToString();
                labelAsigurare.Text = pacient.Asigurare ? "Asigurat" : "Neasigurat";
                labelTelefon.Text = pacient.Telefon;
                labelLocalitate.Text = pacient.Localitate;
                labelJudet.Text = pacient.Judet;
                labelStrada.Text = pacient.Strada;
                labelNumar.Text = pacient.Numar;
                labelBloc.Text = pacient.Bloc;
                labelScara.Text = pacient.Scara;
                labelApartament.Text = pacient.Apartament;
                labelGrSang.Text = pacient.GrupaSg;
                labelRh.Text = pacient.Rh;
                labelGreutate.Text = pacient.Greutate.ToString();
                labelInaltime.Text = pacient.Inaltime.ToString();
            }
        }

        private void buttonSalveazaModificari_Click(object sender, EventArgs e)
        {
            pacient.CNP = textBoxEditCNP.Text;
            pacient.NrFisa = textBoxEditNrFisa.Text;
            pacient.Gen = textBoxEditGen.Text;
            pacient.Nume = textBoxEditNume.Text;
            pacient.Prenume = textBoxEditPrenume.Text;
            pacient.DataNastere = dateTimePickerEdit.Value;
            pacient.Varsta = int.Parse(textBoxEditVarsta.Text);
            pacient.Asigurare = checkBoxEdit.Checked ? true : false;
            pacient.Telefon = textBoxEditTelefon.Text;
            pacient.Localitate = textBoxEditLocalitate.Text;
            pacient.Judet = textBoxEditJudet.Text;
            pacient.Strada = textBoxEditStrada.Text;
            pacient.Numar = textBoxEditNumar.Text;
            pacient.Bloc = textBoxEditBloc.Text;
            pacient.Scara = textBoxEditScara.Text;
            pacient.Apartament = textBoxEditApartament.Text;
            pacient.GrupaSg = string.IsNullOrEmpty(comboBoxEditGrupaSg.Text) ? "NULL" : comboBoxEditGrupaSg.Text;
            pacient.Rh = string.IsNullOrEmpty(comboBoxEditRh.Text) ? "NULL" : comboBoxEditRh.Text;
            pacient.Greutate = string.IsNullOrEmpty(textBoxEditGreutate.Text) ? 0 : float.Parse(textBoxEditGreutate.Text);
            pacient.Inaltime = string.IsNullOrEmpty(textBoxEditInaltime.Text) ? 0 : int.Parse(textBoxEditInaltime.Text);

            _dbContext.Update(pacient);
            _dbContext.SaveChanges();
            var response = MessageBox.Show("Datele pacientului au fost modificate", "", MessageBoxButtons.OK);
            if (response == DialogResult.OK)
            {
                parentForm.refreshPatientsList();
                this.Close();
            }
        }

        private async void tabControlPatient_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlPacient.SelectedTab == tabPageIstoricMedical)
            {
                listViewConsultatiiPacient.Items.Clear();

                var consultatii = await _dbContext.Consultatie
                    .Where(consultatie => consultatie.CnpPacient.Equals(pacient.CNP))
                    .OrderByDescending(consultatie => consultatie.DataConsultatie)
                    .ToListAsync();
                foreach (var consultatie in consultatii)
                {
                    var diagnostic = _dbContext.Diagnostic.Where(diagnostic => diagnostic.CodDiagnostic.Equals(consultatie.CodDiagnostic)).FirstOrDefault();

                    if (diagnostic != null)
                    {
                        var row = new string[] { consultatie.DataConsultatie.ToString("d"), diagnostic.NumeDiagnostic, consultatie.Medicatie };
                        var listItem = new ListViewItem(row);
                        listItem.Tag = consultatie;
                        if (!consultatie.EsteSters && !string.IsNullOrEmpty(consultatie.CodDiagnostic))
                            listViewConsultatiiPacient.Items.Add(listItem);
                    }
                }
            }
        }
    }
}
