
namespace EESSP
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAdaugareConsultatie = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonAdaugaConsultatie = new System.Windows.Forms.Button();
            this.datePickerDataConsultatie = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPacient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVizualizareConsultatie = new System.Windows.Forms.Panel();
            this.buttonSalveazaConsultatie = new System.Windows.Forms.Button();
            this.textBoxRecomandari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMedicatie = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDataConsultatie = new System.Windows.Forms.TextBox();
            this.buttonSelectDiagnostic = new System.Windows.Forms.Button();
            this.textBoxNumeDiagnostic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCodDiagnostic = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPacientConsultatie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCnpConsultatie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelVizualizareConsultatie = new System.Windows.Forms.Label();
            this.panelAdaugareConsultatie.SuspendLayout();
            this.panelVizualizareConsultatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdaugareConsultatie
            // 
            this.panelAdaugareConsultatie.Controls.Add(this.label24);
            this.panelAdaugareConsultatie.Controls.Add(this.buttonAdaugaConsultatie);
            this.panelAdaugareConsultatie.Controls.Add(this.datePickerDataConsultatie);
            this.panelAdaugareConsultatie.Controls.Add(this.label7);
            this.panelAdaugareConsultatie.Controls.Add(this.textBoxPacient);
            this.panelAdaugareConsultatie.Controls.Add(this.label5);
            this.panelAdaugareConsultatie.Controls.Add(this.textBoxCNP);
            this.panelAdaugareConsultatie.Controls.Add(this.label2);
            this.panelAdaugareConsultatie.Controls.Add(this.label1);
            this.panelAdaugareConsultatie.Location = new System.Drawing.Point(13, 13);
            this.panelAdaugareConsultatie.Name = "panelAdaugareConsultatie";
            this.panelAdaugareConsultatie.Size = new System.Drawing.Size(535, 369);
            this.panelAdaugareConsultatie.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(258, 309);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(277, 19);
            this.label24.TabIndex = 47;
            this.label24.Text = "Campurile marcate cu * sunt obligatorii!";
            // 
            // buttonAdaugaConsultatie
            // 
            this.buttonAdaugaConsultatie.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonAdaugaConsultatie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdaugaConsultatie.Location = new System.Drawing.Point(380, 252);
            this.buttonAdaugaConsultatie.Name = "buttonAdaugaConsultatie";
            this.buttonAdaugaConsultatie.Size = new System.Drawing.Size(107, 38);
            this.buttonAdaugaConsultatie.TabIndex = 46;
            this.buttonAdaugaConsultatie.Text = "Salveaza";
            this.buttonAdaugaConsultatie.UseVisualStyleBackColor = false;
            this.buttonAdaugaConsultatie.Click += new System.EventHandler(this.buttonAdaugaConsultatie_Click);
            // 
            // datePickerDataConsultatie
            // 
            this.datePickerDataConsultatie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerDataConsultatie.Location = new System.Drawing.Point(143, 124);
            this.datePickerDataConsultatie.Name = "datePickerDataConsultatie";
            this.datePickerDataConsultatie.Size = new System.Drawing.Size(124, 23);
            this.datePickerDataConsultatie.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data consultatie *:";
            // 
            // textBoxPacient
            // 
            this.textBoxPacient.Location = new System.Drawing.Point(313, 64);
            this.textBoxPacient.MaxLength = 99999;
            this.textBoxPacient.Name = "textBoxPacient";
            this.textBoxPacient.Size = new System.Drawing.Size(172, 23);
            this.textBoxPacient.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pacient:";
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(80, 64);
            this.textBoxCNP.MaxLength = 13;
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(124, 23);
            this.textBoxCNP.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "CNP *:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creare consultatie";
            // 
            // panelVizualizareConsultatie
            // 
            this.panelVizualizareConsultatie.Controls.Add(this.buttonSalveazaConsultatie);
            this.panelVizualizareConsultatie.Controls.Add(this.textBoxRecomandari);
            this.panelVizualizareConsultatie.Controls.Add(this.label3);
            this.panelVizualizareConsultatie.Controls.Add(this.textBoxMedicatie);
            this.panelVizualizareConsultatie.Controls.Add(this.label12);
            this.panelVizualizareConsultatie.Controls.Add(this.textBoxDataConsultatie);
            this.panelVizualizareConsultatie.Controls.Add(this.buttonSelectDiagnostic);
            this.panelVizualizareConsultatie.Controls.Add(this.textBoxNumeDiagnostic);
            this.panelVizualizareConsultatie.Controls.Add(this.label11);
            this.panelVizualizareConsultatie.Controls.Add(this.textBoxCodDiagnostic);
            this.panelVizualizareConsultatie.Controls.Add(this.label10);
            this.panelVizualizareConsultatie.Controls.Add(this.label9);
            this.panelVizualizareConsultatie.Controls.Add(this.label4);
            this.panelVizualizareConsultatie.Controls.Add(this.textBoxPacientConsultatie);
            this.panelVizualizareConsultatie.Controls.Add(this.label6);
            this.panelVizualizareConsultatie.Controls.Add(this.textBoxCnpConsultatie);
            this.panelVizualizareConsultatie.Controls.Add(this.label8);
            this.panelVizualizareConsultatie.Controls.Add(this.labelVizualizareConsultatie);
            this.panelVizualizareConsultatie.Location = new System.Drawing.Point(13, 12);
            this.panelVizualizareConsultatie.Name = "panelVizualizareConsultatie";
            this.panelVizualizareConsultatie.Size = new System.Drawing.Size(535, 370);
            this.panelVizualizareConsultatie.TabIndex = 48;
            // 
            // buttonSalveazaConsultatie
            // 
            this.buttonSalveazaConsultatie.Location = new System.Drawing.Point(186, 332);
            this.buttonSalveazaConsultatie.Name = "buttonSalveazaConsultatie";
            this.buttonSalveazaConsultatie.Size = new System.Drawing.Size(149, 23);
            this.buttonSalveazaConsultatie.TabIndex = 1;
            this.buttonSalveazaConsultatie.Text = "Salveaza consultatia";
            this.buttonSalveazaConsultatie.UseVisualStyleBackColor = true;
            // 
            // textBoxRecomandari
            // 
            this.textBoxRecomandari.Location = new System.Drawing.Point(303, 242);
            this.textBoxRecomandari.Multiline = true;
            this.textBoxRecomandari.Name = "textBoxRecomandari";
            this.textBoxRecomandari.Size = new System.Drawing.Size(217, 75);
            this.textBoxRecomandari.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(303, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Recomandari";
            // 
            // textBoxMedicatie
            // 
            this.textBoxMedicatie.Location = new System.Drawing.Point(9, 242);
            this.textBoxMedicatie.Multiline = true;
            this.textBoxMedicatie.Name = "textBoxMedicatie";
            this.textBoxMedicatie.Size = new System.Drawing.Size(217, 75);
            this.textBoxMedicatie.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(9, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "Medicatie";
            // 
            // textBoxDataConsultatie
            // 
            this.textBoxDataConsultatie.Location = new System.Drawing.Point(141, 79);
            this.textBoxDataConsultatie.MaxLength = 13;
            this.textBoxDataConsultatie.Name = "textBoxDataConsultatie";
            this.textBoxDataConsultatie.ReadOnly = true;
            this.textBoxDataConsultatie.Size = new System.Drawing.Size(96, 23);
            this.textBoxDataConsultatie.TabIndex = 54;
            // 
            // buttonSelectDiagnostic
            // 
            this.buttonSelectDiagnostic.Location = new System.Drawing.Point(391, 165);
            this.buttonSelectDiagnostic.Name = "buttonSelectDiagnostic";
            this.buttonSelectDiagnostic.Size = new System.Drawing.Size(129, 23);
            this.buttonSelectDiagnostic.TabIndex = 53;
            this.buttonSelectDiagnostic.Text = "Selecteaza diagnostic";
            this.buttonSelectDiagnostic.UseVisualStyleBackColor = true;
            this.buttonSelectDiagnostic.Click += new System.EventHandler(this.buttonSelectDiagnostic_Click);
            // 
            // textBoxNumeDiagnostic
            // 
            this.textBoxNumeDiagnostic.Location = new System.Drawing.Point(104, 181);
            this.textBoxNumeDiagnostic.MaxLength = 13;
            this.textBoxNumeDiagnostic.Name = "textBoxNumeDiagnostic";
            this.textBoxNumeDiagnostic.ReadOnly = true;
            this.textBoxNumeDiagnostic.Size = new System.Drawing.Size(266, 23);
            this.textBoxNumeDiagnostic.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 51;
            this.label11.Text = "Diagnostic:";
            // 
            // textBoxCodDiagnostic
            // 
            this.textBoxCodDiagnostic.Location = new System.Drawing.Point(136, 151);
            this.textBoxCodDiagnostic.MaxLength = 13;
            this.textBoxCodDiagnostic.Name = "textBoxCodDiagnostic";
            this.textBoxCodDiagnostic.Size = new System.Drawing.Size(61, 23);
            this.textBoxCodDiagnostic.TabIndex = 50;
            this.textBoxCodDiagnostic.Leave += new System.EventHandler(this.textBoxCodDiagnostic_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Cod diagnostic *:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Diagnostic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data consultatie *:";
            // 
            // textBoxPacientConsultatie
            // 
            this.textBoxPacientConsultatie.Location = new System.Drawing.Point(313, 43);
            this.textBoxPacientConsultatie.MaxLength = 99999;
            this.textBoxPacientConsultatie.Name = "textBoxPacientConsultatie";
            this.textBoxPacientConsultatie.ReadOnly = true;
            this.textBoxPacientConsultatie.Size = new System.Drawing.Size(172, 23);
            this.textBoxPacientConsultatie.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pacient:";
            // 
            // textBoxCnpConsultatie
            // 
            this.textBoxCnpConsultatie.Location = new System.Drawing.Point(80, 43);
            this.textBoxCnpConsultatie.MaxLength = 13;
            this.textBoxCnpConsultatie.Name = "textBoxCnpConsultatie";
            this.textBoxCnpConsultatie.ReadOnly = true;
            this.textBoxCnpConsultatie.Size = new System.Drawing.Size(124, 23);
            this.textBoxCnpConsultatie.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "CNP *:";
            // 
            // labelVizualizareConsultatie
            // 
            this.labelVizualizareConsultatie.AutoSize = true;
            this.labelVizualizareConsultatie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVizualizareConsultatie.Location = new System.Drawing.Point(0, 0);
            this.labelVizualizareConsultatie.Name = "labelVizualizareConsultatie";
            this.labelVizualizareConsultatie.Size = new System.Drawing.Size(158, 19);
            this.labelVizualizareConsultatie.TabIndex = 1;
            this.labelVizualizareConsultatie.Text = "Vizualizare consultatie";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 395);
            this.Controls.Add(this.panelVizualizareConsultatie);
            this.Controls.Add(this.panelAdaugareConsultatie);
            this.Name = "Form4";
            this.Text = "Sanitary Manager";
            this.Load += new System.EventHandler(this.Form4_onLoad);
            this.panelAdaugareConsultatie.ResumeLayout(false);
            this.panelAdaugareConsultatie.PerformLayout();
            this.panelVizualizareConsultatie.ResumeLayout(false);
            this.panelVizualizareConsultatie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdaugareConsultatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPacient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button buttonAdaugaConsultatie;
        private System.Windows.Forms.DateTimePicker datePickerDataConsultatie;
        private System.Windows.Forms.Panel panelVizualizareConsultatie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPacientConsultatie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCnpConsultatie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelVizualizareConsultatie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCodDiagnostic;
        private System.Windows.Forms.TextBox textBoxNumeDiagnostic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSelectDiagnostic;
        private System.Windows.Forms.TextBox textBoxDataConsultatie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMedicatie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRecomandari;
        private System.Windows.Forms.Button buttonSalveazaConsultatie;
    }
}