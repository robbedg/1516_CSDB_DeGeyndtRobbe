namespace StudentenAdministratie
{
    partial class Form1
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
            this.comboBoxDocenten = new System.Windows.Forms.ComboBox();
            this.listBoxOLAs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxDocenten
            // 
            this.comboBoxDocenten.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxDocenten.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDocenten.FormattingEnabled = true;
            this.comboBoxDocenten.Location = new System.Drawing.Point(12, 12);
            this.comboBoxDocenten.Name = "comboBoxDocenten";
            this.comboBoxDocenten.Size = new System.Drawing.Size(260, 21);
            this.comboBoxDocenten.TabIndex = 0;
            this.comboBoxDocenten.SelectedIndexChanged += new System.EventHandler(this.comboBoxDocenten_SelectedIndexChanged);
            // 
            // listBoxOLAs
            // 
            this.listBoxOLAs.FormattingEnabled = true;
            this.listBoxOLAs.Location = new System.Drawing.Point(12, 39);
            this.listBoxOLAs.Name = "listBoxOLAs";
            this.listBoxOLAs.Size = new System.Drawing.Size(260, 212);
            this.listBoxOLAs.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBoxOLAs);
            this.Controls.Add(this.comboBoxDocenten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "StudentenAdministratie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDocenten;
        private System.Windows.Forms.ListBox listBoxOLAs;
    }
}

