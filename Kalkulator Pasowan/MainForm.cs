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
        Graphics graphicsShaft;
        Graphics graphicsHole;
        TechDrawPainter techDrawPainter = new TechDrawPainter();

        public MainForm()
        {
            InitializeComponent();
            graphicsShaft = pictureBoxShaft.CreateGraphics();
            graphicsHole = pictureBoxHole.CreateGraphics();
            textBoxRollDiameter.Text = "0";
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

                techDrawPainter.drawShaft(graphicsShaft);
                techDrawPainter.drawHole(graphicsHole);
                techDrawPainter.drawRegularTolerationField(graphicsShaft, Convert.ToDouble(labelRollerDimmension.Text), Convert.ToDouble(labelRollerUpperDeviation.Text), Convert.ToDouble(labelRollerLoverDeviation.Text));
                techDrawPainter.drawRegularTolerationField(graphicsHole, Convert.ToDouble(labelHoleDimmension.Text), Convert.ToDouble(labelHoleUpperDeviation.Text), Convert.ToDouble(labelHoleLoverDeviation.Text));
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


                techDrawPainter.drawShaft(graphicsShaft);
                techDrawPainter.drawHole(graphicsHole);
                techDrawPainter.drawRegularTolerationField(graphicsShaft, Convert.ToDouble(labelRollerDimmension.Text), Convert.ToDouble(labelRollerUpperDeviation.Text), Convert.ToDouble(labelRollerLoverDeviation.Text));
                techDrawPainter.drawRegularTolerationField(graphicsHole, Convert.ToDouble(labelHoleDimmension.Text), Convert.ToDouble(labelHoleUpperDeviation.Text), Convert.ToDouble(labelHoleLoverDeviation.Text));
            }
            catch
            {

            }

        }

        private void comboBoxRollerClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labelRollerUpperDeviation.Text = TableToleranceReader.readUpperDeviation(labelRollerDimmension.Text, comboBoxRollerClass.SelectedIndex);
                labelRollerLoverDeviation.Text = TableToleranceReader.readLowerDeviation(labelRollerDimmension.Text, comboBoxRollerClass.SelectedIndex);
                labelRollerDimensionTolerace.Text = TableToleranceReader.readRangeOfTolleration(labelRollerDimmension.Text, comboBoxRollerClass.SelectedIndex);

                techDrawPainter.drawShaft(graphicsShaft);
                techDrawPainter.drawHole(graphicsHole);
                techDrawPainter.drawRegularTolerationField(graphicsShaft, Convert.ToDouble(labelRollerDimmension.Text), Convert.ToDouble(labelRollerUpperDeviation.Text), Convert.ToDouble(labelRollerLoverDeviation.Text));
                techDrawPainter.drawRegularTolerationField(graphicsHole, Convert.ToDouble(labelHoleDimmension.Text), Convert.ToDouble(labelHoleUpperDeviation.Text), Convert.ToDouble(labelHoleLoverDeviation.Text));
            }
            catch
            {

            }
           
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
                labelHoleUpperDeviation.Text = TableToleranceReader.readUpperDeviation(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);
                labelHoleLoverDeviation.Text = TableToleranceReader.readLowerDeviation(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);
                labelHoleDimensionTolerace.Text = TableToleranceReader.readRangeOfTolleration(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);

                techDrawPainter.drawShaft(graphicsShaft);
                techDrawPainter.drawHole(graphicsHole);
                techDrawPainter.drawRegularTolerationField(graphicsShaft, Convert.ToDouble(labelRollerDimmension.Text), Convert.ToDouble(labelRollerUpperDeviation.Text), Convert.ToDouble(labelRollerLoverDeviation.Text));
                techDrawPainter.drawRegularTolerationField(graphicsHole, Convert.ToDouble(labelHoleDimmension.Text), Convert.ToDouble(labelHoleUpperDeviation.Text), Convert.ToDouble(labelHoleLoverDeviation.Text));
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxHoleTolerance_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int previousSelectedValue = Convert.ToInt16(comboBoxHoleClass.Text);
                comboBoxHoleClass.Items.Clear();
                comboBoxHoleClass.Items.AddRange(TableToleranceReader.ReadAvalibleITClasses(comboBoxHoleTolerance.Text));
                if (comboBoxHoleClass.Items.IndexOf(Convert.ToString(previousSelectedValue)) == -1)
                {
                    comboBoxHoleClass.SelectedIndex = 0;
                }
                else
                {
                    comboBoxHoleClass.SelectedIndex = comboBoxHoleClass.Items.IndexOf(Convert.ToString(previousSelectedValue));
                }
                labelHoleUpperDeviation.Text = TableToleranceReader.readUpperDeviation(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);
                labelHoleLoverDeviation.Text = TableToleranceReader.readLowerDeviation(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);
                labelHoleDimensionTolerace.Text = TableToleranceReader.readRangeOfTolleration(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);

                techDrawPainter.drawShaft(graphicsShaft);
                techDrawPainter.drawHole(graphicsHole);
                techDrawPainter.drawRegularTolerationField(graphicsShaft, Convert.ToDouble(labelRollerDimmension.Text), Convert.ToDouble(labelRollerUpperDeviation.Text), Convert.ToDouble(labelRollerLoverDeviation.Text));
                techDrawPainter.drawRegularTolerationField(graphicsHole, Convert.ToDouble(labelHoleDimmension.Text), Convert.ToDouble(labelHoleUpperDeviation.Text), Convert.ToDouble(labelHoleLoverDeviation.Text));
            }
            catch
            {

            }
        }

        private void comboBoxHoleClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHoleUpperDeviation.Text = TableToleranceReader.readUpperDeviation(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);
            labelHoleLoverDeviation.Text = TableToleranceReader.readLowerDeviation(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);
            labelHoleDimensionTolerace.Text = TableToleranceReader.readRangeOfTolleration(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);
        }

        private void pictureBoxShaft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxShaft_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }

        private void comboBoxHoleClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                labelHoleUpperDeviation.Text = TableToleranceReader.readUpperDeviation(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);
                labelHoleLoverDeviation.Text = TableToleranceReader.readLowerDeviation(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);
                labelHoleDimensionTolerace.Text = TableToleranceReader.readRangeOfTolleration(labelHoleDimmension.Text, comboBoxHoleClass.SelectedIndex);

                techDrawPainter.drawShaft(graphicsShaft);
                techDrawPainter.drawHole(graphicsHole);
                techDrawPainter.drawRegularTolerationField(graphicsShaft, Convert.ToDouble(labelRollerDimmension.Text), Convert.ToDouble(labelRollerUpperDeviation.Text), Convert.ToDouble(labelRollerLoverDeviation.Text));
                techDrawPainter.drawRegularTolerationField(graphicsHole, Convert.ToDouble(labelHoleDimmension.Text), Convert.ToDouble(labelHoleUpperDeviation.Text), Convert.ToDouble(labelHoleLoverDeviation.Text));
            }
            catch
            {

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
