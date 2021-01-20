
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
            this.panelAdaugareConsultatie.SuspendLayout();
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
            this.panelAdaugareConsultatie.Size = new System.Drawing.Size(535, 328);
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 353);
            this.Controls.Add(this.panelAdaugareConsultatie);
            this.Name = "Form4";
            this.Text = "Sanitary Manager";
            this.Load += new System.EventHandler(this.Form4_onLoad);
            this.panelAdaugareConsultatie.ResumeLayout(false);
            this.panelAdaugareConsultatie.PerformLayout();
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
    }
}