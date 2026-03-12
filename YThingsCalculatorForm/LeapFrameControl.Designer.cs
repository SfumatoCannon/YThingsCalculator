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
            richTextBox1 = new RichTextBox();
            buttonRefresh = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(buttonRefresh, 2, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1375, 998);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.Controls.Add(radioButtonLandingY, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxLandingY, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 296);
            tableLayoutPanel3.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel3.Size = new Size(509, 48);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // radioButtonLandingY
            // 
            radioButtonLandingY.Anchor = AnchorStyles.Right;
            radioButtonLandingY.AutoCheck = false;
            radioButtonLandingY.AutoSize = true;
            radioButtonLandingY.Location = new Point(19, 6);
            radioButtonLandingY.Margin = new Padding(5, 5, 5, 5);
            radioButtonLandingY.Name = "radioButtonLandingY";
            radioButtonLandingY.Size = new Size(163, 35);
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
            textBoxLandingY.Location = new Point(192, 5);
            textBoxLandingY.Margin = new Padding(5, 5, 5, 5);
            textBoxLandingY.Name = "textBoxLandingY";
            textBoxLandingY.Size = new Size(312, 38);
            textBoxLandingY.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxStartY, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 238);
            tableLayoutPanel2.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.Size = new Size(509, 48);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(5, 8);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 31);
            label1.TabIndex = 0;
            label1.Text = "Start Y:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxStartY
            // 
            textBoxStartY.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxStartY.ForeColor = Color.Black;
            textBoxStartY.Location = new Point(192, 5);
            textBoxStartY.Margin = new Padding(5, 5, 5, 5);
            textBoxStartY.Name = "textBoxStartY";
            textBoxStartY.Size = new Size(312, 38);
            textBoxStartY.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(560, 236);
            richTextBox1.Name = "richTextBox1";
            tableLayoutPanel1.SetRowSpan(richTextBox1, 4);
            richTextBox1.Size = new Size(773, 420);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Right;
            buttonRefresh.Location = new Point(1183, 687);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(150, 46);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // LeapFrameControl
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LeapFrameControl";
            Size = new Size(1375, 998);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private RadioButton radioButtonLimitDeadly;
        private RadioButton radioButtonLimitSolid;
        private TableLayoutPanel tableLayoutPanel6;
        private Button buttonYAlignSearch;
        private Button buttonYAlignCancel;
        private CheckBox checkBoxCactus;
        private CheckBox checkBoxJumpCancel;
        private CheckBox checkBoxPlatformLanding;
        private CheckBox checkBoxSingleJumpOnly;
        private CheckBox checkBoxNoBunnyHop;
        private RichTextBox richTextBox1;
        private Button buttonRefresh;
    }
}
