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
        private Form4 parentForm;

        public Form5(Form4 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private async void Form5_onLoad(object sender, EventArgs e)
        {
            listViewDiagnostic.Items.Clear();

            var diagnostice = await _dbContext.Diagnostic.OrderBy(diagnostic => diagnostic.CodDiagnostic).ToListAsync();
            foreach (var diagnostic in diagnostice)
            {
                var row = new string[] { diagnostic.CodDiagnostic.Trim(),diagnostic.NumeDiagnostic.Trim() };
                var listItem = new ListViewItem(row);
                listItem.Tag = diagnostic;
                listViewDiagnostic.Items.Add(listItem);
            }
        }

        private void buttonSelectDiagnostic_Click(object sender, EventArgs e)
        {
            var codDiagnostic = listViewDiagnostic.SelectedItems[0].SubItems[0].Text;
            parentForm.codDiagnosticResult = codDiagnostic;
            this.Close();
        }
    }
}
