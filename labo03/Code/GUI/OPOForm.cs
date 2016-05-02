using Enums;
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
    public partial class OPOForm : Form
    {
        private Manipulations logic { get; set; }
        public OPOForm(Manipulations logic)
        {
            InitializeComponent();
            this.logic = logic;
            comboBoxFase.Items.Add(Enums.Fase.fase1);
            comboBoxFase.Items.Add(Enums.Fase.fase2);
            comboBoxFase.Items.Add(Enums.Fase.fase3);

            comboBoxSemester.Items.Add(Semester.sem1);
            comboBoxSemester.Items.Add(Semester.sem2);

            comboBoxResp.Items.AddRange(logic.lecturers.ToArray());
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            OPO newopo = new OPO((int)logic.opos.Count + 1, (string)textBoxCode.Text, (string)textBoxName.Text, (int)numericUpDownSTP.Value, logic.lecturers.ToArray()[comboBoxResp.SelectedIndex], (Fase)comboBoxFase.SelectedItem, (Semester)comboBoxSemester.SelectedItem);
            logic.AddOPO(newopo);
            this.Close();
        }
    }
}
