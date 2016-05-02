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

namespace GUI
{
    public partial class MainForm : Form
    {
        private Manipulations logic { get; set; }
        public MainForm()
        {
            InitializeComponent();
            logic = new Manipulations();
            Reload();
        }

        public void Reload()
        {
            LecturerBox.Items.Clear();
            LecturerBox.Items.AddRange(logic.lecturers.ToArray<Lecturer>());
        }

        private void addLecturer_Click(object sender, EventArgs e)
        {
            NewLecturer nl = new NewLecturer(logic);
            nl.Show();
        }

        private void LecturerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OLAsView.Items.AddRange(logic.GetOLAs((Lecturer)LecturerBox.SelectedValue).ToArray<ListViewItem>());
        }

        private void LecturerBox_MouseClick(object sender, MouseEventArgs e)
        {
            Reload();
        }

        private void buttonNewOPO_Click(object sender, EventArgs e)
        {
            OPOForm of = new OPOForm(logic);
            of.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OLAForm of = new OLAForm(logic);
            of.Show();
        }
    }
}
