﻿using System;
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
        public Form2()
        {
            InitializeComponent();
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
    }
}
