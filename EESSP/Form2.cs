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
    public partial class Form2 : Form
    {
        private ProjectContext _dbContext = new ProjectContext();
        private Pacient pacient;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Pacient pacient)
        {
            InitializeComponent();
            this.pacient = pacient;
        }

        private void NumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void textBoxCNP_Leave(object sender, EventArgs e)
        {
            if (textBoxCNP.TextLength != 13)
            {
                MessageBox.Show("CNP-ul trebuie sa contina 13 caractere!", "Eroare", MessageBoxButtons.OK);
                textBoxCNP.Focus();
            }
            else
            {
                //setare gen
                if (textBoxCNP.Text[0] == '1' || textBoxCNP.Text[0] == '5')
                    textBoxGen.Text = "M";
                else if (textBoxCNP.Text[0] == '2' || textBoxCNP.Text[0] == '6')
                    textBoxGen.Text = "F";

                //setare data nastere
                string dataNastere = textBoxCNP.Text.Substring(1, 6);
                string anNastere = "", lunaNastere = "", ziuaNastere = "";
                if (textBoxCNP.Text[0] == '1' || textBoxCNP.Text[0] == '2')
                    anNastere = "19" + dataNastere.Substring(0, 2);
                else if (textBoxCNP.Text[0] == '5' || textBoxCNP.Text[0] == '6')
                    anNastere = "20" + dataNastere.Substring(0, 2);
                lunaNastere = dataNastere.Substring(2, 2);
                ziuaNastere = dataNastere.Substring(4, 2);
                datePickerDataNastere.Value = new DateTime(int.Parse(anNastere), int.Parse(lunaNastere), int.Parse(ziuaNastere));

                var today = DateTime.Today;
                var varsta = today.Year - datePickerDataNastere.Value.Year;
                if (datePickerDataNastere.Value.Date.Date > today.AddYears(-varsta))
                    varsta--;
                textBoxVarsta.Text = varsta.ToString();
            }
        }

        private void buttonAdaugaPacient_Click(object sender, EventArgs e)
        {
            var newPacient = new Pacient()
            {
                CNP = textBoxCNP.Text,
                NrFisa = textBoxNumarFisa.Text,
                Gen = textBoxGen.Text,
                Nume = textBoxNume.Text,
                Prenume = textBoxPrenume.Text,
                DataNastere = datePickerDataNastere.Value,
                Varsta = int.Parse(textBoxVarsta.Text),
                Asigurare = checkBoxAsigurat.Checked ? true : false,
                Telefon = textBoxTelefon.Text,
                Localitate = textBoxLocalitate.Text,
                Judet = textBoxJudet.Text,
                Strada = textBoxStrada.Text,
                Numar = textBoxNumar.Text,
                Bloc = textBoxBloc.Text,
                Scara = textBoxScara.Text,
                Apartament = textBoxApartament.Text,
                GrupaSg = string.IsNullOrEmpty(comboBoxGrSanguina.Text) ? "NULL" : comboBoxGrSanguina.Text,
                Rh = string.IsNullOrEmpty(comboBoxRh.Text) ? "NULL" : comboBoxRh.Text,
                Greutate = string.IsNullOrEmpty(textBoxGreutate.Text) ? 0 : float.Parse(textBoxGreutate.Text),
                Inaltime = string.IsNullOrEmpty(textBoxInaltime.Text) ? 0 : int.Parse(textBoxInaltime.Text),
                DataDeces = new DateTime(2999, 01, 01),
                EstePacient = true
            };

            _dbContext.Pacient.Add(newPacient);
            _dbContext.SaveChanges();
            MessageBox.Show("Pacientul a fost introdul in sistem.", "", MessageBoxButtons.OK);
            this.Close();
        }

        private void Form2_onLoad(object sender, EventArgs e)
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

            _dbContext.SaveChanges();
            MessageBox.Show("Datele pacientului au fost modificate", "", MessageBoxButtons.OK);
        }
    }
}
