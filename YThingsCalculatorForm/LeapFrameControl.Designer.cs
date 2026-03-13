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
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            textBoxLeapInput = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            integerTextBoxLandingY = new YAlignCalculator.IntegerTextBox();
            checkBoxLandingY = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            textBoxStartY = new YAlignCalculator.FloatStepperTextBox();
            richTextBoxResult = new RichTextBox();
            buttonRefresh = new Button();
            labelLeapExplain = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBoxResult, 2, 1);
            tableLayoutPanel1.Controls.Add(buttonRefresh, 2, 5);
            tableLayoutPanel1.Controls.Add(labelLeapExplain, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7489328F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.15884F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.1588364F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.9333878F));
            tableLayoutPanel1.Size = new Size(1375, 998);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(textBoxLeapInput, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(5, 224);
            tableLayoutPanel4.Margin = new Padding(5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 249F));
            tableLayoutPanel4.Size = new Size(508, 257);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(33, 226);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 31);
            label2.TabIndex = 0;
            label2.Text = "Leap String:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxLeapInput
            // 
            textBoxLeapInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLeapInput.Location = new Point(190, 216);
            textBoxLeapInput.Name = "textBoxLeapInput";
            textBoxLeapInput.Size = new Size(315, 38);
            textBoxLeapInput.TabIndex = 1;
            textBoxLeapInput.TextChanged += textBoxLeapInput_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.Controls.Add(integerTextBoxLandingY, 1, 0);
            tableLayoutPanel3.Controls.Add(checkBoxLandingY, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 170);
            tableLayoutPanel3.Margin = new Padding(5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel3.Size = new Size(508, 44);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // integerTextBoxLandingY
            // 
            integerTextBoxLandingY.Anchor = AnchorStyles.Left;
            integerTextBoxLandingY.Enabled = false;
            integerTextBoxLandingY.ForeColor = Color.Black;
            integerTextBoxLandingY.Location = new Point(190, 3);
            integerTextBoxLandingY.Name = "integerTextBoxLandingY";
            integerTextBoxLandingY.Size = new Size(99, 38);
            integerTextBoxLandingY.TabIndex = 4;
            // 
            // checkBoxLandingY
            // 
            checkBoxLandingY.Anchor = AnchorStyles.Right;
            checkBoxLandingY.AutoSize = true;
            checkBoxLandingY.Location = new Point(20, 4);
            checkBoxLandingY.Name = "checkBoxLandingY";
            checkBoxLandingY.Size = new Size(164, 35);
            checkBoxLandingY.TabIndex = 8;
            checkBoxLandingY.Text = "Landing Y:";
            checkBoxLandingY.UseVisualStyleBackColor = true;
            checkBoxLandingY.CheckedChanged += checkBoxLandingY_CheckedChanged;
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
            tableLayoutPanel2.Location = new Point(5, 112);
            tableLayoutPanel2.Margin = new Padding(5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.Size = new Size(508, 48);
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
            textBoxStartY.Margin = new Padding(5);
            textBoxStartY.Name = "textBoxStartY";
            textBoxStartY.Size = new Size(311, 38);
            textBoxStartY.TabIndex = 1;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Dock = DockStyle.Fill;
            richTextBoxResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxResult.Location = new Point(559, 110);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(richTextBoxResult, 4);
            richTextBoxResult.Size = new Size(771, 640);
            richTextBoxResult.TabIndex = 4;
            richTextBoxResult.Text = "";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Right;
            buttonRefresh.Location = new Point(1180, 781);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(150, 46);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // labelLeapExplain
            // 
            labelLeapExplain.AutoSize = true;
            labelLeapExplain.Dock = DockStyle.Fill;
            labelLeapExplain.ForeColor = SystemColors.ControlDark;
            labelLeapExplain.Location = new Point(3, 486);
            labelLeapExplain.Name = "labelLeapExplain";
            labelLeapExplain.Size = new Size(512, 267);
            labelLeapExplain.TabIndex = 7;
            labelLeapExplain.Text = "jump1:\r\npause:\r\njump2:";
            labelLeapExplain.TextAlign = ContentAlignment.TopRight;
            // 
            // LeapFrameControl
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "LeapFrameControl";
            Size = new Size(1375, 998);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
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
        private RichTextBox richTextBoxResult;
        private Button buttonRefresh;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox textBoxLeapInput;
        private Label labelLeapExplain;
        private YAlignCalculator.IntegerTextBox integerTextBoxLandingY;
        private CheckBox checkBoxLandingY;
    }
}
