using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YThingsCalculatorCore;

namespace YThingsCalculatorForm
{
    public partial class LeapFrameControl : UserControl
    {
        public LeapFrameControl()
        {
            InitializeComponent();
            textBoxStartY.Text = ((double)407.4f).ToString("R");
        }

        private void checkBoxLandingY_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLandingY.Checked)
            {
                integerTextBoxLandingY.Enabled = true;
                if (double.TryParse(textBoxStartY.Text, out double startY))
                {
                    integerTextBoxLandingY.Text = ((int)Math.Round(startY)).ToString();
                }
            }
            else
            {
                integerTextBoxLandingY.Enabled = false;
                integerTextBoxLandingY.Text = "";
            }
        }

        private void textBoxLeapInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStartY.ForeColor == Color.Red)
            {
                return;
            }
            if (checkBoxLandingY.Checked && integerTextBoxLandingY.ForeColor == Color.Red)
            {
                return;
            }
            
            try
            {
                LeapFormat leapFormat = new LeapFormat(textBoxLeapInput.Text);
                float startY = float.Parse(textBoxStartY.Text);
                if (checkBoxLandingY.Checked)
                {
                    int endFloorY = int.Parse(integerTextBoxLandingY.Text);
                    var leapFrameList = LeapSimulation.GetFrameYList(startY, leapFormat, endFloorY);
                    richTextBoxResult.Clear();
                    for (int i = 0; i < leapFrameList.Count; i++)
                    {
                        richTextBoxResult.SelectionColor = Color.LightGray;
                        richTextBoxResult.AppendText($"{i,3}|");
                        richTextBoxResult.SelectionColor = Color.Black;
                        richTextBoxResult.AppendText($" {((double)leapFrameList[i]).ToString("R")}\n");
                    }
                }
                else
                {

                }
            }
            catch (FormatException ex)
            {
                // string errorMessage = ex.Message;
            }
        }
    }
}
