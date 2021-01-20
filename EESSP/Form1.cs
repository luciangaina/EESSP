using EESSP.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EESSP
{
    public enum Screen
    {
        ModificaPacient,
        FisaPacient,
        AdaugaConsultatieCnp
    }
    public partial class MainApp : Form
    {
        private ProjectContext _dbContext = new ProjectContext();
        public MainApp()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void pacientiMenuItem_onClick(object sender, EventArgs e)
        {
            panelPacienti.BringToFront();
            refreshPatientsList();
        }

        public async void refreshPatientsList()
        {
            listViewPacienti.Items.Clear();

            var pacienti = await _dbContext.Pacient.OrderBy(pacient => pacient.Nume).ToListAsync();
            foreach (var pacient in pacienti)
            {
                var row = new string[] { pacient.Nume, pacient.Prenume, pacient.Varsta.ToString(), pacient.Gen, pacient.CNP, pacient.NrFisa };
                var listItem = new ListViewItem(row);
                listItem.Tag = pacient;
                if (!pacient.EstePacient)
                    listItem.ForeColor = Color.Magenta;
                listViewPacienti.Items.Add(listItem);
            }
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            Form2 adaugarePacient = new Form2(this);
            adaugarePacient.Show();
        }

        private void buttonDeathPatient_Click(object sender, EventArgs e)
        {
            var cnpPacient = listViewPacienti.SelectedItems[0].SubItems[4].Text;

            var pacient = _dbContext.Pacient.Where(pacient => pacient.CNP == cnpPacient).FirstOrDefault();

            var textMessageBox = "Doriti sa inregistrati decesul pentru pacientul " + pacient.Nume + " " + pacient.Prenume + "?";
            var response = MessageBox.Show(textMessageBox, "", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                pacient.DataDeces = DateTime.Today;
                _dbContext.SaveChanges();
                MessageBox.Show("Decesul a fost inregistrat.", "", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Decesul nu a fost inregistrat.", "", MessageBoxButtons.OK);
        }

        private void buttonExitedPatient_Click(object sender, EventArgs e)
        {
            var cnpPacient = listViewPacienti.SelectedItems[0].SubItems[4].Text;

            var pacient = _dbContext.Pacient.Where(pacient => pacient.CNP == cnpPacient).FirstOrDefault();

            var textMessageBox = "Doriti sa inregistrati iesirea pacientului: " + pacient.Nume + " " + pacient.Prenume + "?";
            var response = MessageBox.Show(textMessageBox, "", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                pacient.EstePacient = false;
                _dbContext.SaveChanges();
                MessageBox.Show("Iesirea pacientului a fost inregistrata.", "", MessageBoxButtons.OK);
                refreshPatientsList();
            }
            else
                MessageBox.Show("Iesirea pacientului nu a fost inregistrata.", "", MessageBoxButtons.OK);
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            if (listViewPacienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pacientul nu a fost selectat!", "Eroare", MessageBoxButtons.OK);
            }
            else
            {
                var cnpPacient = listViewPacienti.SelectedItems[0].SubItems[4].Text;
                var pacient = _dbContext.Pacient.Where(pacient => pacient.CNP == cnpPacient).FirstOrDefault();

                Form3 editarePacient = new Form3(this, pacient, Screen.ModificaPacient);
                editarePacient.Show();
            }
        }

        private void consultatiiMenuItem_onClick(object sender, EventArgs e)
        {
            panelConsultatii.BringToFront();
            refreshConsultatiiList();
        }

        private async void refreshConsultatiiList()
        {
            listViewConsultatii.Items.Clear();

            var consultatii = await _dbContext.Consultatie.OrderBy(consultatie => consultatie.DataConsultatie).ToListAsync();
            foreach (var consultatie in consultatii)
            {
                var pacient = _dbContext.Pacient.Where(pacient => pacient.CNP.Equals(consultatie.CnpPacient)).FirstOrDefault();
                var numePacient = pacient.Nume.Trim() + " " + pacient.Prenume.Trim();

                var row = new string[] { consultatie.Id.ToString(), consultatie.DataConsultatie.ToString("d"), consultatie.DataConsultatie.TimeOfDay.ToString(), numePacient };
                var listItem = new ListViewItem(row);
                listItem.Tag = consultatie;
                if (!consultatie.EsteSters)
                    listViewConsultatii.Items.Add(listItem);
            }
        }

        private void buttonVizualizareFisa_Click(object sender, EventArgs e)
        {
            if (listViewPacienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pacientul nu a fost selectat!", "Eroare", MessageBoxButtons.OK);
            }
            else
            {
                var cnpPacient = listViewPacienti.SelectedItems[0].SubItems[4].Text;
                var pacient = _dbContext.Pacient.Where(pacient => pacient.CNP == cnpPacient).FirstOrDefault();

                if (pacient.EstePacient)
                {
                    Form3 editarePacient = new Form3(this, pacient, Screen.FisaPacient);
                    editarePacient.Show();
                }
                else
                    MessageBox.Show("Pacientul selectat nu mai apartine sistemului!", "Eroare", MessageBoxButtons.OK);
            }
        }

        private void buttonCreazaConsultatie_Click(object sender, EventArgs e)
        {
            if (listViewPacienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pacientul nu a fost selectat!", "Eroare", MessageBoxButtons.OK);
            }
            else
            {
                var cnpPacient = listViewPacienti.SelectedItems[0].SubItems[4].Text;
                var pacient = _dbContext.Pacient.Where(pacient => pacient.CNP == cnpPacient).FirstOrDefault();

                Form4 adaugareConsultatie = new Form4(pacient, Screen.AdaugaConsultatieCnp);
                adaugareConsultatie.Show();
            }
        }

        private void buttonStergeConsultatie_Click(object sender, EventArgs e)
        {
            if (listViewConsultatii.SelectedItems.Count == 0)
            {
                MessageBox.Show("Consultatia nu a fost selectata!", "Eroare", MessageBoxButtons.OK);
            }
            else
            {
                var idConsultatie = int.Parse(listViewConsultatii.SelectedItems[0].SubItems[0].Text);
                var consultatie = _dbContext.Consultatie.Where(consultatie => consultatie.Id == idConsultatie).FirstOrDefault();

                consultatie.EsteSters = true;
                _dbContext.Update(consultatie);
                _dbContext.SaveChanges();
                var response = MessageBox.Show("Consultatia a fost stearsa.", "", MessageBoxButtons.OK);
                if (response == DialogResult.OK)
                    refreshConsultatiiList();
            }
        }
    }
}
