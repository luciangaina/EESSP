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
    public partial class Form1 : Form
    {
        private ProjectContext _dbContext;
        public Form1()
        {
            InitializeComponent();
        }

        private async void onLoad(object sender, EventArgs e)
        {
            _dbContext = new ProjectContext();

            var pacienti = await _dbContext.Pacient.ToListAsync();
        }
    }
}
