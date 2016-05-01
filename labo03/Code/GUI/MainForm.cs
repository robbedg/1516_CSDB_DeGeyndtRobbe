﻿using Logic;
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
            LecturerBox.Items.AddRange(logic.GetLecturers());
        }

        private void addLecturer_Click(object sender, EventArgs e)
        {
            NewLecturer nl = new NewLecturer(logic);
            nl.Show();
        }

        private void LecturerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LecturerBox_MouseClick(object sender, MouseEventArgs e)
        {
            Reload();
        }
    }
}
