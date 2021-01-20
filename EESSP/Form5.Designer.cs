
namespace EESSP
{
    partial class Form5
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
            this.listViewDiagnostic = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listViewDiagnostic
            // 
            this.listViewDiagnostic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDiagnostic.GridLines = true;
            this.listViewDiagnostic.HideSelection = false;
            this.listViewDiagnostic.Location = new System.Drawing.Point(12, 12);
            this.listViewDiagnostic.Name = "listViewDiagnostic";
            this.listViewDiagnostic.Size = new System.Drawing.Size(462, 182);
            this.listViewDiagnostic.TabIndex = 0;
            this.listViewDiagnostic.UseCompatibleStateImageBehavior = false;
            this.listViewDiagnostic.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod 999";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Diagnostic";
            this.columnHeader2.Width = 390;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 206);
            this.Controls.Add(this.listViewDiagnostic);
            this.Name = "Form5";
            this.Text = "Sanitary Manager";
            this.Load += new System.EventHandler(this.Form5_onLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDiagnostic;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}