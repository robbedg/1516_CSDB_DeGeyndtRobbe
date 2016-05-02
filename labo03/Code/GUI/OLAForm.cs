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
    public partial class OLAForm : Form
    {
        private Manipulations logic { get; set; }
        private OLA ola { get; set; }
        public OLAForm(Manipulations logic, OLA ola)
        {
            InitializeComponent();
            this.logic = logic;
            this.ola = ola;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //logic.UpdateOLA();
            this.Close();
        }
    }
}
