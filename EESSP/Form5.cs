using EESSP.Contexts;
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
    public partial class Form5 : Form
    {
        private ProjectContext _dbContext = new ProjectContext();

        public Form5()
        {
            InitializeComponent();
        }

        private async void Form5_onLoad(object sender, EventArgs e)
        {
            listViewDiagnostic.Items.Clear();

            var diagnostice = await _dbContext.Diagnostic.ToListAsync();
            foreach (var diagnostic in diagnostice)
            {
                var row = new string[] { diagnostic.CodDiagnostic.Trim(),diagnostic.NumeDiagnostic.Trim() };
                var listItem = new ListViewItem(row);
                listItem.Tag = diagnostic;
                listViewDiagnostic.Items.Add(listItem);
            }
        }
    }
}
