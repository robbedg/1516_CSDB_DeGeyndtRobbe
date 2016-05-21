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
        private Student selectedStudent { get; set; }
        public Assign(Manipulations logic)
        {
            InitializeComponent();
            this.Logic = logic;
            cbStudent.Items.AddRange(Logic.GetAllStudents().OrderBy(student => student.Name).ToArray());
        }

        private void clbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbCourses.Items.Clear();
            clbCourses.Items.AddRange(Logic.GetAllCourses().OrderBy(student => student.Name).ToArray());

            selectedStudent = (Student)cbStudent.SelectedItem;
            List<Course> filtered = Logic.GetCoursesOnStudent(selectedStudent);

            foreach (Course x in clbCourses.Items)
            {
                if (filtered.Contains(x))
                {
                    int index = clbCourses.Items.IndexOf(x);
                    clbCourses.SetItemChecked(index, true);
                }
            }
        }
    }
}
