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
    public partial class Form4 : Form
    {
        private ProjectContext _dbContext = new ProjectContext();
        private Pacient pacient;
        private Screen screen;
        private MainApp parentForm;

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
    }
}
