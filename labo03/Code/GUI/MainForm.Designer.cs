namespace GUI
{
    partial class MainForm
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
            this.LecturerBox = new System.Windows.Forms.ComboBox();
            this.OLAsView = new System.Windows.Forms.ListView();
            this.addLecturer = new System.Windows.Forms.Button();
            this.buttonNewOPO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LecturerBox
            // 
            this.LecturerBox.FormattingEnabled = true;
            this.LecturerBox.Location = new System.Drawing.Point(12, 12);
            this.LecturerBox.Name = "LecturerBox";
            this.LecturerBox.Size = new System.Drawing.Size(376, 21);
            this.LecturerBox.TabIndex = 0;
            this.LecturerBox.SelectedIndexChanged += new System.EventHandler(this.LecturerBox_SelectedIndexChanged);
            this.LecturerBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LecturerBox_MouseClick);
            // 
            // OLAsView
            // 
            this.OLAsView.Location = new System.Drawing.Point(12, 48);
            this.OLAsView.Name = "OLAsView";
            this.OLAsView.Size = new System.Drawing.Size(376, 97);
            this.OLAsView.TabIndex = 1;
            this.OLAsView.UseCompatibleStateImageBehavior = false;
            // 
            // addLecturer
            // 
            this.addLecturer.Location = new System.Drawing.Point(394, 10);
            this.addLecturer.Name = "addLecturer";
            this.addLecturer.Size = new System.Drawing.Size(94, 23);
            this.addLecturer.TabIndex = 2;
            this.addLecturer.Text = "Nieuwe Docent";
            this.addLecturer.UseVisualStyleBackColor = true;
            this.addLecturer.Click += new System.EventHandler(this.addLecturer_Click);
            // 
            // buttonNewOPO
            // 
            this.buttonNewOPO.Location = new System.Drawing.Point(394, 39);
            this.buttonNewOPO.Name = "buttonNewOPO";
            this.buttonNewOPO.Size = new System.Drawing.Size(94, 23);
            this.buttonNewOPO.TabIndex = 3;
            this.buttonNewOPO.Text = "Nieuwe OPO";
            this.buttonNewOPO.UseVisualStyleBackColor = true;
            this.buttonNewOPO.Click += new System.EventHandler(this.buttonNewOPO_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update OLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNewOPO);
            this.Controls.Add(this.addLecturer);
            this.Controls.Add(this.OLAsView);
            this.Controls.Add(this.LecturerBox);
            this.Name = "MainForm";
            this.Text = "  ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox LecturerBox;
        private System.Windows.Forms.ListView OLAsView;
        private System.Windows.Forms.Button addLecturer;
        private System.Windows.Forms.Button buttonNewOPO;
        private System.Windows.Forms.Button button1;
    }
}

