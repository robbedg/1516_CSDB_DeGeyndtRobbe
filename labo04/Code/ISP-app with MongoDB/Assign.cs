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
    public partial class Assign : Form
    {
        private Manipulations Logic { get; set; }
        private Student SelectedStudent { get; set; }
        private List<Course> Courses { get; set; }
        public Assign(Manipulations logic)
        {
            InitializeComponent();
            this.Logic = logic;
            cbStudent.Items.AddRange(Logic.GetAllStudents().OrderBy(student => student.Name).ToArray());
            Courses = Logic.GetAllCourses();
        }

        //Ubdate assignments
        private void clbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedStudent.Courses.Clear();
            
            foreach (Course x in clbCourses.CheckedItems)
            {
                SelectedStudent.Courses.Add(x);
            }

            Logic.UpdateStudent(SelectedStudent);
        }

        //Set items checked
        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbCourses.Items.Clear();
            clbCourses.Items.AddRange(Courses.OrderBy(course => course.Name).ToArray());

            SelectedStudent = (Student)cbStudent.SelectedItem;
            List<Course> filtered = Logic.GetCoursesOnStudent(SelectedStudent);

            foreach (Course x in Courses)
            {
                foreach (Course y in filtered)
                {
                    if (x.Id == y.Id)
                    {
                        int index = clbCourses.Items.IndexOf(x);
                        clbCourses.SetItemChecked(index, true);
                    }
                }
            }
        }
    }
}
