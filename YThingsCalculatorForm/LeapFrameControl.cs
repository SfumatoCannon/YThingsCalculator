using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YThingsCalculatorForm
{
    public partial class LeapFrameControl : UserControl
    {
        public LeapFrameControl()
        {
            InitializeComponent();
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
    }
}
