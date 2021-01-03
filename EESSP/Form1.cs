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
            var pacienti = await _dbContext.Pacient.ToListAsync();

            listViewPacienti.Items.Clear();
            foreach(var pacient in pacienti)
            {
                var row = new string[]{ pacient.Nume, pacient.Prenume, pacient.Varsta.ToString(), pacient.Gen, pacient.CNP, pacient.NrFisa };
                var listItem = new ListViewItem(row);
                listItem.Tag = pacient;
                listViewPacienti.Items.Add(listItem);
            }
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            Form2 adaugarePacient = new Form2();
            adaugarePacient.Show();
        }

    }
}
