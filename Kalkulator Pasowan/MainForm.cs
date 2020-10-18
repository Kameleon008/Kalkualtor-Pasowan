using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Pasowan
{
    public partial class MainForm : Form
    {
        ToleratedSize rollerToleratedSize = new ToleratedSize();
        ToleratedSize holeToleratedSize = new ToleratedSize();
        TableToleranceReader TableToleranceReader = new TableToleranceReader();

        public MainForm()
        {
            InitializeComponent();
            textBoxRollDiameter.Text = "10";
            comboBoxRollerClass.Text = "7";
            comboBoxRollerTolerance.Text = "h";
            textBoxHoleDiameter.Text = "10";
            comboBoxHoleClass.Text = "7";
            comboBoxHoleTolerance.Text = "H";


        }

        private void labelRollerClass_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRollerTolerance_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int previousSelectedValue = Convert.ToInt16(comboBoxRollerClass.Text);
                comboBoxRollerClass.Items.Clear();
                comboBoxRollerClass.Items.AddRange(TableToleranceReader.ReadAvalibleITClasses(comboBoxRollerTolerance.Text));
                if (comboBoxRollerClass.Items.IndexOf(Convert.ToString(previousSelectedValue)) == -1)
                {
                    comboBoxRollerClass.SelectedIndex = 0;
                }
                else
                {
                    comboBoxRollerClass.SelectedIndex = comboBoxRollerClass.Items.IndexOf(Convert.ToString(previousSelectedValue));
                }
                labelRollerUpperDeviation.Text = TableToleranceReader.readUpperDeviation(labelRollerDimmension.Text, comboBoxRollerClass.SelectedIndex);
                labelRollerLoverDeviation.Text = TableToleranceReader.readLowerDeviation(labelRollerDimmension.Text, comboBoxRollerClass.SelectedIndex);
                labelRollerDimensionTolerace.Text = TableToleranceReader.readRangeOfTolleration(labelRollerDimmension.Text, comboBoxRollerClass.SelectedIndex);
            }
            catch
            {

            }
            
        }

        private void textBoxRollDiameter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rollerToleratedSize.ChangeDimmension(Convert.ToDouble(textBoxRollDiameter.Text));
                labelRollerDimmension.Text = Convert.ToString(rollerToleratedSize.GetNominalDimension());
                labelRollerUpperDeviation.Text = TableToleranceReader.readUpperDeviation(labelRollerDimmension.Text,comboBoxRollerClass.SelectedIndex);
                labelRollerLoverDeviation.Text = TableToleranceReader.readLowerDeviation(labelRollerDimmension.Text,comboBoxRollerClass.SelectedIndex);
                labelRollerDimensionTolerace.Text = TableToleranceReader.readRangeOfTolleration(labelRollerDimmension.Text, comboBoxRollerClass.SelectedIndex);
            }
            catch
            {

            }

        }

        private void comboBoxRollerClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelRollerUpperDeviation.Text = TableToleranceReader.readUpperDeviation(labelRollerDimmension.Text, comboBoxRollerClass.SelectedIndex);
            labelRollerLoverDeviation.Text = TableToleranceReader.readLowerDeviation(labelRollerDimmension.Text, comboBoxRollerClass.SelectedIndex);
            labelRollerDimensionTolerace.Text = TableToleranceReader.readRangeOfTolleration(labelRollerDimmension.Text, comboBoxRollerClass.SelectedIndex);
        }

        private void groupBoxRoll_Enter(object sender, EventArgs e)
        {
           //groupBoxRoll.c
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Kalkulator_Pasowan.GroupBoxNew groupBoxNew;
        }

        private void groupBoxNew1_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxNewRoller_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxNew1_Load_1(object sender, EventArgs e)
        {

        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHoleDiameter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                holeToleratedSize.ChangeDimmension(Convert.ToDouble(textBoxHoleDiameter.Text));
                labelHoleDimmension.Text = Convert.ToString(holeToleratedSize.GetNominalDimension());
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
