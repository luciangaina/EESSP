
namespace EESSP
{
    partial class MainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPacienti = new System.Windows.Forms.Panel();
            this.buttonCreazaConsultatie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVizualizareFisa = new System.Windows.Forms.Button();
            this.listViewPacienti = new System.Windows.Forms.ListView();
            this.chNume = new System.Windows.Forms.ColumnHeader();
            this.chPrenume = new System.Windows.Forms.ColumnHeader();
            this.chGen = new System.Windows.Forms.ColumnHeader();
            this.chVarsta = new System.Windows.Forms.ColumnHeader();
            this.chCNP = new System.Windows.Forms.ColumnHeader();
            this.chNrFisa = new System.Windows.Forms.ColumnHeader();
            this.buttonExitedPatient = new System.Windows.Forms.Button();
            this.buttonDeathPatient = new System.Windows.Forms.Button();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.pacientiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultatiiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listViewConsultatii = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.buttonStergeConsultatie = new System.Windows.Forms.Button();
            this.buttonModificaConsultatie = new System.Windows.Forms.Button();
            this.buttonAdaugaConsultatie = new System.Windows.Forms.Button();
            this.buttonVizualizareConsultatie = new System.Windows.Forms.Button();
            this.panelConsultatii = new System.Windows.Forms.Panel();
            this.panelHome.SuspendLayout();
            this.panelPacienti.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelConsultatii.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Location = new System.Drawing.Point(13, 28);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(775, 410);
            this.panelHome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(235, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sanitary Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPacienti
            // 
            this.panelPacienti.Controls.Add(this.buttonCreazaConsultatie);
            this.panelPacienti.Controls.Add(this.label3);
            this.panelPacienti.Controls.Add(this.label2);
            this.panelPacienti.Controls.Add(this.buttonVizualizareFisa);
            this.panelPacienti.Controls.Add(this.listViewPacienti);
            this.panelPacienti.Controls.Add(this.buttonExitedPatient);
            this.panelPacienti.Controls.Add(this.buttonDeathPatient);
            this.panelPacienti.Controls.Add(this.buttonEditPatient);
            this.panelPacienti.Controls.Add(this.buttonAddPatient);
            this.panelPacienti.Location = new System.Drawing.Point(13, 27);
            this.panelPacienti.Name = "panelPacienti";
            this.panelPacienti.Size = new System.Drawing.Size(775, 410);
            this.panelPacienti.TabIndex = 2;
            // 
            // buttonCreazaConsultatie
            // 
            this.buttonCreazaConsultatie.Location = new System.Drawing.Point(34, 194);
            this.buttonCreazaConsultatie.Name = "buttonCreazaConsultatie";
            this.buttonCreazaConsultatie.Size = new System.Drawing.Size(119, 23);
            this.buttonCreazaConsultatie.TabIndex = 9;
            this.buttonCreazaConsultatie.Text = "Creaza consultatie";
            this.toolTip1.SetToolTip(this.buttonCreazaConsultatie, "Creaza o consultatie pentru un pacient.");
            this.buttonCreazaConsultatie.UseVisualStyleBackColor = true;
            this.buttonCreazaConsultatie.Click += new System.EventHandler(this.buttonCreazaConsultatie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Iesire pacient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gestiune pacient";
            // 
            // buttonVizualizareFisa
            // 
            this.buttonVizualizareFisa.Location = new System.Drawing.Point(34, 146);
            this.buttonVizualizareFisa.Name = "buttonVizualizareFisa";
            this.buttonVizualizareFisa.Size = new System.Drawing.Size(119, 23);
            this.buttonVizualizareFisa.TabIndex = 6;
            this.buttonVizualizareFisa.Text = "Vizualizare fisa";
            this.toolTip1.SetToolTip(this.buttonVizualizareFisa, "Vizualizati fisa pacientului selectat. (Selectati un pacient!)");
            this.buttonVizualizareFisa.UseVisualStyleBackColor = true;
            this.buttonVizualizareFisa.Click += new System.EventHandler(this.buttonVizualizareFisa_Click);
            // 
            // listViewPacienti
            // 
            this.listViewPacienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chPrenume,
            this.chGen,
            this.chVarsta,
            this.chCNP,
            this.chNrFisa});
            this.listViewPacienti.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewPacienti.FullRowSelect = true;
            this.listViewPacienti.GridLines = true;
            this.listViewPacienti.HideSelection = false;
            this.listViewPacienti.Location = new System.Drawing.Point(227, 22);
            this.listViewPacienti.Name = "listViewPacienti";
            this.listViewPacienti.Size = new System.Drawing.Size(524, 372);
            this.listViewPacienti.TabIndex = 5;
            this.toolTip1.SetToolTip(this.listViewPacienti, "Lista pacientilor");
            this.listViewPacienti.UseCompatibleStateImageBehavior = false;
            this.listViewPacienti.View = System.Windows.Forms.View.Details;
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            this.chNume.Width = 100;
            // 
            // chPrenume
            // 
            this.chPrenume.Text = "Prenume";
            this.chPrenume.Width = 130;
            // 
            // chGen
            // 
            this.chGen.DisplayIndex = 3;
            this.chGen.Text = "Gen";
            this.chGen.Width = 40;
            // 
            // chVarsta
            // 
            this.chVarsta.DisplayIndex = 2;
            this.chVarsta.Text = "Varsta";
            this.chVarsta.Width = 50;
            // 
            // chCNP
            // 
            this.chCNP.Text = "CNP";
            this.chCNP.Width = 100;
            // 
            // chNrFisa
            // 
            this.chNrFisa.Text = "Numar fisa";
            this.chNrFisa.Width = 100;
            // 
            // buttonExitedPatient
            // 
            this.buttonExitedPatient.Location = new System.Drawing.Point(34, 351);
            this.buttonExitedPatient.Name = "buttonExitedPatient";
            this.buttonExitedPatient.Size = new System.Drawing.Size(119, 23);
            this.buttonExitedPatient.TabIndex = 4;
            this.buttonExitedPatient.Text = "Iesire pacient";
            this.toolTip1.SetToolTip(this.buttonExitedPatient, "Inregistrarea iesirii unui pacient din lista dumneavoastra");
            this.buttonExitedPatient.UseVisualStyleBackColor = true;
            this.buttonExitedPatient.Click += new System.EventHandler(this.buttonExitedPatient_Click);
            // 
            // buttonDeathPatient
            // 
            this.buttonDeathPatient.Location = new System.Drawing.Point(34, 310);
            this.buttonDeathPatient.Name = "buttonDeathPatient";
            this.buttonDeathPatient.Size = new System.Drawing.Size(119, 23);
            this.buttonDeathPatient.TabIndex = 3;
            this.buttonDeathPatient.Text = "Inregistrare deces";
            this.toolTip1.SetToolTip(this.buttonDeathPatient, "Inregistrare decesului pacientului (selectare pacient)");
            this.buttonDeathPatient.UseVisualStyleBackColor = true;
            this.buttonDeathPatient.Click += new System.EventHandler(this.buttonDeathPatient_Click);
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Location = new System.Drawing.Point(34, 105);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(119, 23);
            this.buttonEditPatient.TabIndex = 2;
            this.buttonEditPatient.Text = "Modificare pacient";
            this.toolTip1.SetToolTip(this.buttonEditPatient, "Modificarea datelor pacientului (selectati pacientul)");
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            this.buttonEditPatient.Click += new System.EventHandler(this.buttonEditPatient_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(34, 60);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(119, 23);
            this.buttonAddPatient.TabIndex = 0;
            this.buttonAddPatient.Text = "Adaugare pacient";
            this.toolTip1.SetToolTip(this.buttonAddPatient, "Adaugarea unui nou pacient in sistem");
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientiMenuItem,
            this.consultatiiMenuItem,
            this.ajutorMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // pacientiMenuItem
            // 
            this.pacientiMenuItem.Name = "pacientiMenuItem";
            this.pacientiMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pacientiMenuItem.Text = "&Pacienti";
            this.pacientiMenuItem.Click += new System.EventHandler(this.pacientiMenuItem_onClick);
            // 
            // consultatiiMenuItem
            // 
            this.consultatiiMenuItem.Name = "consultatiiMenuItem";
            this.consultatiiMenuItem.Size = new System.Drawing.Size(76, 20);
            this.consultatiiMenuItem.Text = "&Consultatii";
            this.consultatiiMenuItem.Click += new System.EventHandler(this.consultatiiMenuItem_onClick);
            // 
            // ajutorMenuItem
            // 
            this.ajutorMenuItem.Name = "ajutorMenuItem";
            this.ajutorMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajutorMenuItem.Text = "&Ajutor";
            // 
            // listViewConsultatii
            // 
            this.listViewConsultatii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewConsultatii.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewConsultatii.FullRowSelect = true;
            this.listViewConsultatii.GridLines = true;
            this.listViewConsultatii.HideSelection = false;
            this.listViewConsultatii.Location = new System.Drawing.Point(304, 60);
            this.listViewConsultatii.Name = "listViewConsultatii";
            this.listViewConsultatii.Size = new System.Drawing.Size(447, 334);
            this.listViewConsultatii.TabIndex = 5;
            this.toolTip1.SetToolTip(this.listViewConsultatii, "Lista pacientilor");
            this.listViewConsultatii.UseCompatibleStateImageBehavior = false;
            this.listViewConsultatii.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data consultatie";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ora";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pacient";
            this.columnHeader3.Width = 150;
            // 
            // buttonStergeConsultatie
            // 
            this.buttonStergeConsultatie.Location = new System.Drawing.Point(57, 266);
            this.buttonStergeConsultatie.Name = "buttonStergeConsultatie";
            this.buttonStergeConsultatie.Size = new System.Drawing.Size(134, 23);
            this.buttonStergeConsultatie.TabIndex = 4;
            this.buttonStergeConsultatie.Text = "Stergere consultatie";
            this.toolTip1.SetToolTip(this.buttonStergeConsultatie, "Inregistrarea iesirii unui pacient din lista dumneavoastra");
            this.buttonStergeConsultatie.UseVisualStyleBackColor = true;
            this.buttonStergeConsultatie.Click += new System.EventHandler(this.buttonStergeConsultatie_Click);
            // 
            // buttonModificaConsultatie
            // 
            this.buttonModificaConsultatie.Location = new System.Drawing.Point(57, 204);
            this.buttonModificaConsultatie.Name = "buttonModificaConsultatie";
            this.buttonModificaConsultatie.Size = new System.Drawing.Size(134, 23);
            this.buttonModificaConsultatie.TabIndex = 2;
            this.buttonModificaConsultatie.Text = "Modificare consultatie";
            this.toolTip1.SetToolTip(this.buttonModificaConsultatie, "Modificarea datelor pacientului (selectati pacientul)");
            this.buttonModificaConsultatie.UseVisualStyleBackColor = true;
            // 
            // buttonAdaugaConsultatie
            // 
            this.buttonAdaugaConsultatie.Location = new System.Drawing.Point(57, 89);
            this.buttonAdaugaConsultatie.Name = "buttonAdaugaConsultatie";
            this.buttonAdaugaConsultatie.Size = new System.Drawing.Size(134, 23);
            this.buttonAdaugaConsultatie.TabIndex = 0;
            this.buttonAdaugaConsultatie.Text = "Adaugare consultatie";
            this.toolTip1.SetToolTip(this.buttonAdaugaConsultatie, "Adaugarea unui nou pacient in sistem");
            this.buttonAdaugaConsultatie.UseVisualStyleBackColor = true;
            // 
            // buttonVizualizareConsultatie
            // 
            this.buttonVizualizareConsultatie.Location = new System.Drawing.Point(57, 146);
            this.buttonVizualizareConsultatie.Name = "buttonVizualizareConsultatie";
            this.buttonVizualizareConsultatie.Size = new System.Drawing.Size(134, 23);
            this.buttonVizualizareConsultatie.TabIndex = 6;
            this.buttonVizualizareConsultatie.Text = "Vizualizare consultatie";
            this.toolTip1.SetToolTip(this.buttonVizualizareConsultatie, "Adaugarea unui diagnostic pacientului consultat.");
            this.buttonVizualizareConsultatie.UseVisualStyleBackColor = true;
            this.buttonVizualizareConsultatie.Click += new System.EventHandler(this.buttonVizualizareConsultatie_Click);
            // 
            // panelConsultatii
            // 
            this.panelConsultatii.Controls.Add(this.buttonVizualizareConsultatie);
            this.panelConsultatii.Controls.Add(this.listViewConsultatii);
            this.panelConsultatii.Controls.Add(this.buttonStergeConsultatie);
            this.panelConsultatii.Controls.Add(this.buttonModificaConsultatie);
            this.panelConsultatii.Controls.Add(this.buttonAdaugaConsultatie);
            this.panelConsultatii.Location = new System.Drawing.Point(13, 27);
            this.panelConsultatii.Name = "panelConsultatii";
            this.panelConsultatii.Size = new System.Drawing.Size(775, 410);
            this.panelConsultatii.TabIndex = 6;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelConsultatii);
            this.Controls.Add(this.panelPacienti);
            this.Controls.Add(this.panelHome);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainApp";
            this.Text = "Sanitary Manager";
            this.Load += new System.EventHandler(this.onLoad);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelPacienti.ResumeLayout(false);
            this.panelPacienti.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelConsultatii.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPacienti;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem pacientiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultatiiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorMenuItem;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Button buttonDeathPatient;
        private System.Windows.Forms.Button buttonExitedPatient;
        private System.Windows.Forms.ListView listViewPacienti;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chPrenume;
        private System.Windows.Forms.ColumnHeader chGen;
        private System.Windows.Forms.ColumnHeader chVarsta;
        private System.Windows.Forms.ColumnHeader chCNP;
        private System.Windows.Forms.ColumnHeader chNrFisa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelConsultatii;
        private System.Windows.Forms.ListView listViewConsultatii;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonStergeConsultatie;
        private System.Windows.Forms.Button buttonModificaConsultatie;
        private System.Windows.Forms.Button buttonAdaugaConsultatie;
        private System.Windows.Forms.Button buttonVizualizareFisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreazaConsultatie;
        private System.Windows.Forms.Button buttonVizualizareConsultatie;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

