namespace YThingsCalculatorForm
{
    partial class LeapFrameControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            radioButtonLandingY = new RadioButton();
            textBoxLandingY = new YAlignCalculator.FloatStepperTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            textBoxStartY = new YAlignCalculator.FloatStepperTextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            integerTextBoxHeightLimit = new YAlignCalculator.IntegerTextBox();
            radioButtonSolidHeightLimit = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(1080, 773);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(radioButtonLandingY, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxLandingY, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 216);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(706, 38);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // radioButtonLandingY
            // 
            radioButtonLandingY.Anchor = AnchorStyles.Right;
            radioButtonLandingY.AutoCheck = false;
            radioButtonLandingY.AutoSize = true;
            radioButtonLandingY.Location = new Point(18, 5);
            radioButtonLandingY.Margin = new Padding(4);
            radioButtonLandingY.Name = "radioButtonLandingY";
            radioButtonLandingY.Size = new Size(125, 28);
            radioButtonLandingY.TabIndex = 3;
            radioButtonLandingY.TabStop = true;
            radioButtonLandingY.Text = "Landing Y:";
            radioButtonLandingY.TextAlign = ContentAlignment.MiddleRight;
            radioButtonLandingY.UseVisualStyleBackColor = true;
            // 
            // textBoxLandingY
            // 
            textBoxLandingY.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxLandingY.ForeColor = Color.Black;
            textBoxLandingY.Location = new Point(151, 4);
            textBoxLandingY.Margin = new Padding(4);
            textBoxLandingY.Name = "textBoxLandingY";
            textBoxLandingY.Size = new Size(551, 30);
            textBoxLandingY.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxStartY, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 170);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel2.Size = new Size(706, 38);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(4, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 24);
            label1.TabIndex = 0;
            label1.Text = "Start Y:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxStartY
            // 
            textBoxStartY.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxStartY.ForeColor = Color.Black;
            textBoxStartY.Location = new Point(151, 4);
            textBoxStartY.Margin = new Padding(4);
            textBoxStartY.Name = "textBoxStartY";
            textBoxStartY.Size = new Size(551, 30);
            textBoxStartY.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(integerTextBoxHeightLimit, 1, 0);
            tableLayoutPanel4.Controls.Add(label5, 2, 0);
            tableLayoutPanel4.Controls.Add(radioButtonSolidHeightLimit, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 373);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.MinimumSize = new Size(550, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(706, 38);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("宋体", 9F);
            label5.Location = new Point(588, 10);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(26, 18);
            label5.TabIndex = 3;
            label5.Text = "px";
            // 
            // integerTextBoxHeightLimit
            // 
            integerTextBoxHeightLimit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            integerTextBoxHeightLimit.Enabled = false;
            integerTextBoxHeightLimit.ForeColor = Color.Black;
            integerTextBoxHeightLimit.Location = new Point(466, 4);
            integerTextBoxHeightLimit.Margin = new Padding(4);
            integerTextBoxHeightLimit.Name = "integerTextBoxHeightLimit";
            integerTextBoxHeightLimit.Size = new Size(114, 30);
            integerTextBoxHeightLimit.TabIndex = 2;
            // 
            // radioButtonSolidHeightLimit
            // 
            radioButtonSolidHeightLimit.Anchor = AnchorStyles.Right;
            radioButtonSolidHeightLimit.AutoCheck = false;
            radioButtonSolidHeightLimit.AutoSize = true;
            radioButtonSolidHeightLimit.Location = new Point(264, 5);
            radioButtonSolidHeightLimit.Margin = new Padding(4);
            radioButtonSolidHeightLimit.Name = "radioButtonSolidHeightLimit";
            radioButtonSolidHeightLimit.Size = new Size(194, 28);
            radioButtonSolidHeightLimit.TabIndex = 4;
            radioButtonSolidHeightLimit.TabStop = true;
            radioButtonSolidHeightLimit.Text = "Solid Height Limit:";
            radioButtonSolidHeightLimit.TextAlign = ContentAlignment.MiddleRight;
            radioButtonSolidHeightLimit.UseVisualStyleBackColor = true;
            // 
            // LeapFrameControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "LeapFrameControl";
            Size = new Size(1080, 773);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private RadioButton radioButtonStrategyFastest;
        private RadioButton radioButtonStrategyEasiest;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton radioButtonLandingY;
        private YAlignCalculator.FloatStepperTextBox textBoxLandingY;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private YAlignCalculator.FloatStepperTextBox textBoxStartY;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton radioButtonLimitDeadly;
        private RadioButton radioButtonLimitSolid;
        private Label label5;
        private YAlignCalculator.IntegerTextBox integerTextBoxHeightLimit;
        private RadioButton radioButtonSolidHeightLimit;
        private TableLayoutPanel tableLayoutPanel6;
        private Button buttonYAlignSearch;
        private Button buttonYAlignCancel;
        private CheckBox checkBoxCactus;
        private CheckBox checkBoxJumpCancel;
        private CheckBox checkBoxPlatformLanding;
        private CheckBox checkBoxSingleJumpOnly;
        private CheckBox checkBoxNoBunnyHop;
    }
}
