using Logic;
using Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISP_app_with_MongoDB
{
    public partial class Overview : Form
    {
        private Manipulations Logic { get; set; }
        public Overview()
        {
            InitializeComponent();
            Logic = new Manipulations();
        }

        private void bAddStudent_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(Logic, "Student");
            edit.Show();
        }

        private void bAddCourse_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(Logic, "Course");
            edit.Show();
        }

        private void bStudentName_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = Logic.GetStudentOnName(tStudentName.Text);
                Edit edit = new Edit(Logic, student);
                edit.Show();
            }
            catch
            {
                ErrorMessage("There are either no results or more than one result for entry: [" + tStudentName.Text + "]\nPlease try again.");
            }
        }

        private void bStudentId_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = Logic.GetStudentOnID(Int32.Parse(tStudentId.Text));
                Edit edit = new Edit(Logic, student);
                edit.Show();
            }
            catch
            {
                ErrorMessage("The entry: [" + tStudentId.Text + "] is invalid.\nPlease try again.");
            }
        }

        private void bCourseName_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = Logic.GetCourseOnName(tCourseName.Text);
                Edit edit = new Edit(Logic, course);
                edit.Show();
            }
            catch
            {
                ErrorMessage("There are either no results or more than one result for entry: [" + tCourseName.Text + "]\nPlease try again.");
            }
        }

        private void bCourseId_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = Logic.GetCourseOnID(Int32.Parse(tCourseId.Text));
                Edit edit = new Edit(Logic, course);
                edit.Show();
            }
            catch
            {
                ErrorMessage("The entry: [" + tCourseId.Text + "] is invalid.\nPlease try again.");
            }
        }

        private void bCoursesStudent_Click(object sender, EventArgs e)
        {
            Assign assign = new Assign(Logic);
            assign.Show();
        }

        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
