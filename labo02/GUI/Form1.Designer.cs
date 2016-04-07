namespace GUI
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chkSproc = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.chkClassic = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(145, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 199);
            this.listBox1.TabIndex = 0;
            // 
            // chkSproc
            // 
            this.chkSproc.Location = new System.Drawing.Point(145, 217);
            this.chkSproc.Name = "chkSproc";
            this.chkSproc.Size = new System.Drawing.Size(127, 34);
            this.chkSproc.TabIndex = 1;
            this.chkSproc.Text = "check voorraad sproc";
            this.chkSproc.UseVisualStyleBackColor = true;
            this.chkSproc.Click += new System.EventHandler(this.chkSproc_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(127, 199);
            this.listBox2.TabIndex = 2;
            // 
            // chkClassic
            // 
            this.chkClassic.Location = new System.Drawing.Point(12, 217);
            this.chkClassic.Name = "chkClassic";
            this.chkClassic.Size = new System.Drawing.Size(127, 34);
            this.chkClassic.TabIndex = 3;
            this.chkClassic.Text = "check voorraad klassiek";
            this.chkClassic.UseVisualStyleBackColor = true;
            this.chkClassic.Click += new System.EventHandler(this.chkClassic_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 199);
            this.dataGridView1.TabIndex = 4;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(713, 217);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 34);
            this.update.TabIndex = 5;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkClassic);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.chkSproc);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button chkSproc;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button chkClassic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update;
    }
}

