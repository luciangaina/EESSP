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

        private async void onLoad(object sender, EventArgs e)
        {
            _dbContext = new ProjectContext();

            var pacienti = await _dbContext.Pacient.ToListAsync();

            panelHome.BringToFront();
        }

        private void pacientiMenuItem_onClick(object sender, EventArgs e)
        {
            panelPacienti.BringToFront();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            Form2 adaugarePacient = new Form2();
            adaugarePacient.Show();
        }

    }
}
