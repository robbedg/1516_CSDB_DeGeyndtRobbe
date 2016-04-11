using Logic;
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
    public partial class Form1 : Form
    {
        Process logic = new Process();

        public Form1()
        {
            InitializeComponent();
            //Fill combobox
            comboBoxFrom.Items.AddRange(logic.availableDBs);
            comboBoxFrom.SelectedIndex = 0;
            //Fill combobox
            comboBoxTo.Items.AddRange(logic.availableDBs);
            comboBoxTo.Items.Add("all");
            comboBoxTo.SelectedIndex = logic.availableDBs.Count();
            //Set default
            logic.activeDB = (string)comboBoxFrom.SelectedItem;
            logic.updateTo = (string)comboBoxTo.SelectedItem;
            //Get Data
            logic.GetData();
            dataGridView1.DataSource = logic.dataSet.Tables[0];
        }

        //Get items with SProc
        private void chkSproc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(logic.Sproc());
        }

        //Get items with C# code
        private void chkClassic_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(logic.Classic());
        }

        //Update values in datagrid
        private void update_Click(object sender, EventArgs e)
        {
            dataGridView1.CommitEdit(new DataGridViewDataErrorContexts());
            logic.UpdateData();
            logic.GetData();
            dataGridView1.DataSource = logic.dataSet.Tables[0];
        }

        //Change DB used to get items
        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            logic.activeDB = (string)comboBoxFrom.SelectedItem;
        }

        //Change DB used to save changes
        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            logic.updateTo = (string)comboBoxFrom.SelectedItem;
        }
    }
}
