namespace GUI
{
    partial class NewLecturer
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.Voornaam = new System.Windows.Forms.Label();
            this.textBoxVoornaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNummer = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // textBoxNaam
            // 
            this.textBoxNaam.Location = new System.Drawing.Point(132, 6);
            this.textBoxNaam.Name = "textBoxNaam";
            this.textBoxNaam.Size = new System.Drawing.Size(100, 20);
            this.textBoxNaam.TabIndex = 1;
            // 
            // Voornaam
            // 
            this.Voornaam.AutoSize = true;
            this.Voornaam.Location = new System.Drawing.Point(12, 35);
            this.Voornaam.Name = "Voornaam";
            this.Voornaam.Size = new System.Drawing.Size(55, 13);
            this.Voornaam.TabIndex = 2;
            this.Voornaam.Text = "Voornaam";
            // 
            // textBoxVoornaam
            // 
            this.textBoxVoornaam.Location = new System.Drawing.Point(132, 32);
            this.textBoxVoornaam.Name = "textBoxVoornaam";
            this.textBoxVoornaam.Size = new System.Drawing.Size(100, 20);
            this.textBoxVoornaam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personeelsnummer";
            // 
            // textBoxNummer
            // 
            this.textBoxNummer.Location = new System.Drawing.Point(132, 58);
            this.textBoxNummer.Name = "textBoxNummer";
            this.textBoxNummer.Size = new System.Drawing.Size(100, 20);
            this.textBoxNummer.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(157, 84);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // NewLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 119);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNummer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVoornaam);
            this.Controls.Add(this.Voornaam);
            this.Controls.Add(this.textBoxNaam);
            this.Controls.Add(this.label1);
            this.Name = "NewLecturer";
            this.Text = "NewLecturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNaam;
        private System.Windows.Forms.Label Voornaam;
        private System.Windows.Forms.TextBox textBoxVoornaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNummer;
        private System.Windows.Forms.Button buttonOK;
    }
}