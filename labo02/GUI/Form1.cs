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
        GetInfo info = new GetInfo();
        DataSet artikelen;

        public Form1()
        {
            InitializeComponent();
            artikelen = info.Artikelen();
            dataGridView1.DataSource = artikelen.Tables[0];
        }

        private void chkSproc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(info.Sproc());
        }

        private void chkClassic_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(info.Classic());
        }

        private void update_Click(object sender, EventArgs e)
        {
            dataGridView1.CommitEdit(new DataGridViewDataErrorContexts());
            //artikelen.Tables = (DataSet)dataGridView1.DataSource;
            //artikelen.AcceptChanges();
            info.UpdateArtikelen();
            dataGridView1.DataSource = artikelen.Tables[0];
        }
    }
}
