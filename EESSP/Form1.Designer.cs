
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
            this.panelHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPacienti = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.pacientiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultatiiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHome.SuspendLayout();
            this.menuStrip.SuspendLayout();
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
            this.panelPacienti.Location = new System.Drawing.Point(13, 27);
            this.panelPacienti.Name = "panelPacienti";
            this.panelPacienti.Size = new System.Drawing.Size(775, 410);
            this.panelPacienti.TabIndex = 2;
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
            // 
            // ajutorMenuItem
            // 
            this.ajutorMenuItem.Name = "ajutorMenuItem";
            this.ajutorMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajutorMenuItem.Text = "&Ajutor";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelPacienti);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainApp";
            this.Text = "Sanitary Manager";
            this.Load += new System.EventHandler(this.onLoad);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
    }
}

