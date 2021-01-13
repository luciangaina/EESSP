using EESSP.Contexts;
using EESSP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EESSP
{
    public partial class Form3 : Form
    {
        private ProjectContext _dbContext = new ProjectContext();
        private MainApp parentForm;
        private Pacient pacient;

        public Form3(MainApp parentForm, Pacient pacient)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.pacient = pacient;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_onLoad(object sender, EventArgs e)
        {
            if (pacient != null)
            {
                panelEditPacient.BringToFront();
                textBoxEditCNP.Text = pacient.CNP;
                textBoxEditNrFisa.Text = pacient.NrFisa;
                textBoxEditGen.Text = pacient.Gen;
                textBoxEditNume.Text = pacient.Nume;
                textBoxEditPrenume.Text = pacient.Prenume;
                dateTimePickerEdit.Value = pacient.DataNastere;
                textBoxEditVarsta.Text = pacient.Varsta.ToString();
                checkBoxEdit.Checked = pacient.Asigurare;
                textBoxEditTelefon.Text = pacient.Telefon;
                textBoxEditLocalitate.Text = pacient.Localitate;
                textBoxEditJudet.Text = pacient.Judet;
                textBoxEditStrada.Text = pacient.Strada;
                textBoxEditNumar.Text = pacient.Numar;
                textBoxEditBloc.Text = pacient.Bloc;
                textBoxEditScara.Text = pacient.Scara;
                textBoxEditApartament.Text = pacient.Apartament;
                comboBoxEditGrupaSg.Text = pacient.GrupaSg;
                comboBoxEditRh.Text = pacient.Rh;
                textBoxEditGreutate.Text = pacient.Greutate.ToString();
                textBoxEditInaltime.Text = pacient.Inaltime.ToString();
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
    }
}
