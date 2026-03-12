namespace YThingsCalculatorForm
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabPage1 = new TabPage();
            yAlignAdjustControl1 = new YAlignCalculator.YAlignAdjustControl();
            tabPage2 = new TabPage();
            leapFrameControl1 = new LeapFrameControl();
            tabPage3 = new TabPage();
            tabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Controls.Add(tabPage3);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Margin = new Padding(4);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1354, 961);
            tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(yAlignAdjustControl1);
            tabPage1.Location = new Point(8, 45);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1338, 908);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // yAlignAdjustControl1
            // 
            yAlignAdjustControl1.Dock = DockStyle.Fill;
            yAlignAdjustControl1.Location = new Point(4, 4);
            yAlignAdjustControl1.Margin = new Padding(5);
            yAlignAdjustControl1.Name = "yAlignAdjustControl1";
            yAlignAdjustControl1.Size = new Size(1330, 900);
            yAlignAdjustControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(leapFrameControl1);
            tabPage2.Location = new Point(8, 45);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1338, 908);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // leapFrameControl1
            // 
            leapFrameControl1.Dock = DockStyle.Fill;
            leapFrameControl1.Location = new Point(4, 4);
            leapFrameControl1.Margin = new Padding(4);
            leapFrameControl1.Name = "leapFrameControl1";
            leapFrameControl1.Size = new Size(1330, 900);
            leapFrameControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(8, 45);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(184, 47);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 961);
            Controls.Add(tabControlMain);
            Margin = new Padding(4);
            MinimumSize = new Size(1138, 754);
            Name = "FormMain";
            Text = "Form1";
            tabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private YAlignCalculator.YAlignAdjustControl yAlignAdjustControl1;
        private LeapFrameControl leapFrameControl1;
        private TabPage tabPage3;
    }
}
