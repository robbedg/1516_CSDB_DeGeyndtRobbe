using Context;
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
    public partial class NewLecturer : Form
    {
        private Manipulations logic { get; set; }
        public NewLecturer(Manipulations logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            logic.NewLecturer(textBoxNummer.Text, textBoxNaam.Text, textBoxVoornaam.Text);
            this.Close();
        }
    }
}
