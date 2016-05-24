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
    public partial class Edit : Form
    {
        private Manipulations Logic { get; set; }
        private Student Student { get; set; }
        private Course Course { get; set; }
        private string ObjectName { get; set; }

        #region Constructors

        public Edit(Manipulations logic, string objectName)
        {
            InitializeComponent();
            tId.ReadOnly = false;
            bDelete.Visible = false;
            this.Logic = logic;
            this.ObjectName = objectName;

        }

        public Edit(Manipulations logic, Student student)
        {
            InitializeComponent();
            this.Logic = logic;
            this.Student = student;
            tId.Text = Student.Id.ToString();
            tName.Text = Student.Name;
            tYear.Text = Student.Year;
        }

        public Edit(Manipulations logic, Course course)
        {
            InitializeComponent();
            this.Logic = logic;
            this.Course = course;
            tId.Text = Course.Id.ToString();
            tName.Text = Course.Name;
            tYear.Text = Course.Year;
        }


        #endregion

        //Check what needs to be done, create student/course or update student/course
        private void bDone_Click(object sender, EventArgs e)
        {
            if (Student != null)
            {
                try
                {
                    Student = new Student(Int32.Parse(tId.Text), tName.Text, tYear.Text);
                    Logic.UpdateStudent(Student);
                }
                catch
                {
                    ErrorMessage("Something went wrong.\nPlease try again.");
                }
            }
            else if (Course != null)
            {
                try
                {
                    Course = new Course(Int32.Parse(tId.Text), tName.Text, tYear.Text);
                    Logic.UpdateCourse(Course);
                }
                catch
                {
                    ErrorMessage("Something went wrong.\nPlease try again.");
                }
            }
            else if (ObjectName.Equals("Student"))
            {
                try
                {
                    Student = new Student(Int32.Parse(tId.Text), tName.Text, tYear.Text);
                    Logic.AddStudent(Student);
                }
                catch
                {
                    ErrorMessage("Something went wrong.\nPossibly the chosen id is already used or invalid.\nPlease try again.");
                }
            }
            else if (ObjectName.Equals("Course"))
            {
                try
                {
                    Course = new Course(Int32.Parse(tId.Text), tName.Text, tYear.Text);
                    Logic.AddCourse(Course);
                }
                catch
                {
                    ErrorMessage("Something went wrong.\nPossibly the chosen id is already used or invalid.\nPlease try again.");
                }
            }
            this.Close();
        }

        //Delete course or student.
        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Student != null)
                {
                    Logic.DeleteStudent(Student);
                }
                else if (Course != null)
                {
                    Logic.DeleteCourse(Course);
                }
                else
                {
                    throw new Exception("No object.");
                }
            }
            catch
            {
                ErrorMessage("Something went wrong.\nPlease try again.");
            }
            this.Close();
        }

        //Display errormessage
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
