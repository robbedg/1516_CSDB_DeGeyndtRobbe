using Backend;
using IBackend;
using LogicOLA;
using LogicPersonen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentenAdministratie
{
    public partial class Form1 : Form
    {
        //DBGet
        IDBGet dbget = new DBGet();
        //Docenten
        private Docent[] docenten;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            docenten = dbget.GetDocenten();
            for (int i = 0; i < docenten.Length; i++)
            {
                comboBoxDocenten.Items.Add(docenten[i].ToString().Substring(11));
            }
        }

        private void comboBoxDocenten_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOLAs.Items.Clear();
            int index = comboBoxDocenten.SelectedIndex;

            //Get OLAS
            OLA[] olas = dbget.GetOLAs(docenten[index]);

            //Sort array
            Array.Sort(olas);

            for (int i = 0; i < olas.Length; i++)
            {
                listBoxOLAs.Items.Add(olas[i].ToString());
            }
        }
    }
}
