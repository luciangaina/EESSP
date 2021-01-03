﻿using EESSP.Contexts;
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
    public partial class MainApp : Form
    {
        private ProjectContext _dbContext;
        public MainApp()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            _dbContext = new ProjectContext();
            panelHome.BringToFront();
        }

        private async void pacientiMenuItem_onClick(object sender, EventArgs e)
        {
            panelPacienti.BringToFront();
            var pacienti = await _dbContext.Pacient.OrderBy(pacient => pacient.Nume).ToListAsync();

            listViewPacienti.Items.Clear();
            foreach(var pacient in pacienti)
            {
                var row = new string[]{ pacient.Nume, pacient.Prenume, pacient.Varsta.ToString(), pacient.Gen, pacient.CNP, pacient.NrFisa };
                var listItem = new ListViewItem(row);
                listItem.Tag = pacient;
                if (!pacient.EstePacient)
                    listItem.ForeColor = Color.Magenta;
                listViewPacienti.Items.Add(listItem);
            }
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            Form2 adaugarePacient = new Form2();
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
            }
            else
                MessageBox.Show("Iesirea pacientului nu a fost inregistrata.", "", MessageBoxButtons.OK);
        }
    }
}
