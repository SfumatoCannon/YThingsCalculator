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

        private void showResult()
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
                textBoxLeapInput.ForeColor = Color.Black;
                float startY = float.Parse(textBoxStartY.Text); 
                int startYSnap = (int)(startY / 608) * 608;
                if (checkBoxLandingY.Checked)
                {
                    int endFloorY = int.Parse(integerTextBoxLandingY.Text);
                    var leapFrameList = LeapSimulation.GetFrameYList(startY, leapFormat, endFloorY);
                    richTextBoxResult.Clear();
                    richTextBoxResult.SelectionColor = Color.DarkBlue;
                    richTextBoxResult.AppendText($"Start Y: {startY.ToString("R")}\n" +
                        $"{leapFormat.GetLeapExpression()}" +
                        $" -> {leapFrameList[leapFrameList.Count - 1].ToString("R")}\n");
                    richTextBoxResult.SelectionColor = Color.Gray;
                    richTextBoxResult.AppendText($"{leapFrameList.Count, 3} frames total\n");
                    for (int i = 0; i < leapFrameList.Count; i++)
                    {
                        richTextBoxResult.SelectionColor = Color.Gray;
                        richTextBoxResult.AppendText($"{i,3}|");
                        richTextBoxResult.SelectionColor = Color.Black;
                        richTextBoxResult.AppendText($" {((double)leapFrameList[i]).ToString("R")}\n");
                    }
                }
                else
                {
                    var leapFrameList = LeapSimulation.GetFrameYList(startY, leapFormat, startYSnap + 5000);
                    richTextBoxResult.Clear();
                    richTextBoxResult.Clear();
                    richTextBoxResult.SelectionColor = Color.DarkBlue;
                    richTextBoxResult.AppendText($"Start Y: {startY.ToString("R")}\n" +
                        $"{leapFormat.GetLeapExpression()}\n");
                    for (int i = 0; i < Math.Min(151, leapFrameList.Count); i++)
                    {
                        richTextBoxResult.SelectionColor = Color.Gray;
                        richTextBoxResult.AppendText($"{i,3}|");
                        richTextBoxResult.SelectionColor = Color.Black;
                        richTextBoxResult.AppendText($" {((double)leapFrameList[i]).ToString("R")}\n");
                        if (i == 150 && leapFrameList.Count > 151)
                            richTextBoxResult.AppendText("...");
                    }
                }
            }
            catch (FormatException ex)
            {
                textBoxLeapInput.ForeColor = Color.Red;
            }
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
            showResult();
        }
    }
}
