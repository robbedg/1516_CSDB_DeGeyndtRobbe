namespace ISP_app_with_MongoDB
{
    partial class Overview
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bStudentId = new System.Windows.Forms.Button();
            this.bStudentName = new System.Windows.Forms.Button();
            this.tStudentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAddStudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCourseId = new System.Windows.Forms.Button();
            this.bCourseName = new System.Windows.Forms.Button();
            this.tCourseId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tCourseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bAddCourse = new System.Windows.Forms.Button();
            this.bCoursesStudent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bStudentId);
            this.groupBox1.Controls.Add(this.bStudentName);
            this.groupBox1.Controls.Add(this.tStudentId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tStudentName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bAddStudent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // bStudentId
            // 
            this.bStudentId.Location = new System.Drawing.Point(321, 71);
            this.bStudentId.Name = "bStudentId";
            this.bStudentId.Size = new System.Drawing.Size(150, 20);
            this.bStudentId.TabIndex = 6;
            this.bStudentId.Text = "Search Student (on ID)";
            this.bStudentId.UseVisualStyleBackColor = true;
            this.bStudentId.Click += new System.EventHandler(this.bStudentId_Click);
            // 
            // bStudentName
            // 
            this.bStudentName.Location = new System.Drawing.Point(321, 32);
            this.bStudentName.Name = "bStudentName";
            this.bStudentName.Size = new System.Drawing.Size(150, 20);
            this.bStudentName.TabIndex = 5;
            this.bStudentName.Text = "Search Student (on name)";
            this.bStudentName.UseVisualStyleBackColor = true;
            this.bStudentName.Click += new System.EventHandler(this.bStudentName_Click);
            // 
            // tStudentId
            // 
            this.tStudentId.Location = new System.Drawing.Point(115, 71);
            this.tStudentId.Name = "tStudentId";
            this.tStudentId.Size = new System.Drawing.Size(200, 20);
            this.tStudentId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student\'s ID:";
            // 
            // tStudentName
            // 
            this.tStudentName.Location = new System.Drawing.Point(115, 32);
            this.tStudentName.Name = "tStudentName";
            this.tStudentName.Size = new System.Drawing.Size(200, 20);
            this.tStudentName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student\'s Name:";
            // 
            // bAddStudent
            // 
            this.bAddStudent.Location = new System.Drawing.Point(6, 19);
            this.bAddStudent.Name = "bAddStudent";
            this.bAddStudent.Size = new System.Drawing.Size(100, 72);
            this.bAddStudent.TabIndex = 0;
            this.bAddStudent.Text = "Add";
            this.bAddStudent.UseVisualStyleBackColor = true;
            this.bAddStudent.Click += new System.EventHandler(this.bAddStudent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bCourseId);
            this.groupBox2.Controls.Add(this.bCourseName);
            this.groupBox2.Controls.Add(this.tCourseId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tCourseName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bAddCourse);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Courses";
            // 
            // bCourseId
            // 
            this.bCourseId.Location = new System.Drawing.Point(321, 71);
            this.bCourseId.Name = "bCourseId";
            this.bCourseId.Size = new System.Drawing.Size(150, 20);
            this.bCourseId.TabIndex = 5;
            this.bCourseId.Text = "Search Course (on ID)";
            this.bCourseId.UseVisualStyleBackColor = true;
            this.bCourseId.Click += new System.EventHandler(this.bCourseId_Click);
            // 
            // bCourseName
            // 
            this.bCourseName.Location = new System.Drawing.Point(321, 32);
            this.bCourseName.Name = "bCourseName";
            this.bCourseName.Size = new System.Drawing.Size(150, 20);
            this.bCourseName.TabIndex = 4;
            this.bCourseName.Text = "Search Course (on name)";
            this.bCourseName.UseVisualStyleBackColor = true;
            this.bCourseName.Click += new System.EventHandler(this.bCourseName_Click);
            // 
            // tCourseId
            // 
            this.tCourseId.Location = new System.Drawing.Point(115, 71);
            this.tCourseId.Name = "tCourseId";
            this.tCourseId.Size = new System.Drawing.Size(200, 20);
            this.tCourseId.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course\'s ID:";
            // 
            // tCourseName
            // 
            this.tCourseName.Location = new System.Drawing.Point(115, 32);
            this.tCourseName.Name = "tCourseName";
            this.tCourseName.Size = new System.Drawing.Size(200, 20);
            this.tCourseName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Course\'s Name:";
            // 
            // bAddCourse
            // 
            this.bAddCourse.Location = new System.Drawing.Point(6, 19);
            this.bAddCourse.Name = "bAddCourse";
            this.bAddCourse.Size = new System.Drawing.Size(100, 72);
            this.bAddCourse.TabIndex = 0;
            this.bAddCourse.Text = "Add";
            this.bAddCourse.UseVisualStyleBackColor = true;
            this.bAddCourse.Click += new System.EventHandler(this.bAddCourse_Click);
            // 
            // bCoursesStudent
            // 
            this.bCoursesStudent.Location = new System.Drawing.Point(12, 224);
            this.bCoursesStudent.Name = "bCoursesStudent";
            this.bCoursesStudent.Size = new System.Drawing.Size(480, 50);
            this.bCoursesStudent.TabIndex = 2;
            this.bCoursesStudent.Text = "Assign Course To Student";
            this.bCoursesStudent.UseVisualStyleBackColor = true;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 287);
            this.Controls.Add(this.bCoursesStudent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Overview";
            this.Text = "Overview";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bStudentId;
        private System.Windows.Forms.Button bStudentName;
        private System.Windows.Forms.TextBox tStudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAddCourse;
        private System.Windows.Forms.TextBox tCourseId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCourseId;
        private System.Windows.Forms.Button bCourseName;
        private System.Windows.Forms.Button bCoursesStudent;
    }
}

