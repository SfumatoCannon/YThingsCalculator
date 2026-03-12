namespace YAlignCalculator
{
    partial class YAlignAdjustControl
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            radioButtonStrategyFastest = new RadioButton();
            radioButtonStrategyEasiest = new RadioButton();
            label6 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            textBoxTargetYLeft = new FloatStepperTextBox();
            textBoxTargetYRight = new FloatStepperTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            textBoxStartY = new FloatStepperTextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            radioButtonLimitDeadly = new RadioButton();
            radioButtonLimitSolid = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            integerTextBoxHeightLimit = new IntegerTextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            buttonYAlignSearch = new Button();
            buttonYAlignCancel = new Button();
            checkBoxCactus = new CheckBox();
            checkBoxJumpCancel = new CheckBox();
            checkBoxPlatformLanding = new CheckBox();
            checkBoxSingleJumpOnly = new CheckBox();
            checkBoxNoBunnyHop = new CheckBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            richTextBoxResult = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1MinSize = 500;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel7);
            splitContainer1.Panel2MinSize = 250;
            splitContainer1.Size = new Size(1050, 971);
            splitContainer1.SplitterDistance = 663;
            splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 7);
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
            tableLayoutPanel1.Size = new Size(663, 971);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(radioButtonStrategyFastest, 2, 0);
            tableLayoutPanel5.Controls.Add(radioButtonStrategyEasiest, 1, 0);
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Right;
            tableLayoutPanel5.Location = new Point(210, 400);
            tableLayoutPanel5.Margin = new Padding(4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(449, 36);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // radioButtonStrategyFastest
            // 
            radioButtonStrategyFastest.Anchor = AnchorStyles.Left;
            radioButtonStrategyFastest.AutoSize = true;
            radioButtonStrategyFastest.Location = new Point(306, 4);
            radioButtonStrategyFastest.Margin = new Padding(4);
            radioButtonStrategyFastest.Name = "radioButtonStrategyFastest";
            radioButtonStrategyFastest.Size = new Size(95, 28);
            radioButtonStrategyFastest.TabIndex = 1;
            radioButtonStrategyFastest.TabStop = true;
            radioButtonStrategyFastest.Text = "Fastest";
            radioButtonStrategyFastest.UseVisualStyleBackColor = true;
            // 
            // radioButtonStrategyEasiest
            // 
            radioButtonStrategyEasiest.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButtonStrategyEasiest.AutoSize = true;
            radioButtonStrategyEasiest.Checked = true;
            radioButtonStrategyEasiest.Location = new Point(159, 4);
            radioButtonStrategyEasiest.Margin = new Padding(4);
            radioButtonStrategyEasiest.Name = "radioButtonStrategyEasiest";
            radioButtonStrategyEasiest.Size = new Size(139, 28);
            radioButtonStrategyEasiest.TabIndex = 0;
            radioButtonStrategyEasiest.TabStop = true;
            radioButtonStrategyEasiest.Text = "Easiest";
            radioButtonStrategyEasiest.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(4, 6);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(147, 24);
            label6.TabIndex = 2;
            label6.Text = "Search strategy:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 2, 0);
            tableLayoutPanel3.Controls.Add(textBoxTargetYLeft, 1, 0);
            tableLayoutPanel3.Controls.Add(textBoxTargetYRight, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 205);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(655, 38);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(4, 7);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 24);
            label2.TabIndex = 0;
            label2.Text = "Target Y:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(386, 7);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(29, 24);
            label3.TabIndex = 2;
            label3.Text = "～";
            // 
            // textBoxTargetYLeft
            // 
            textBoxTargetYLeft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxTargetYLeft.ForeColor = Color.Black;
            textBoxTargetYLeft.Location = new Point(151, 4);
            textBoxTargetYLeft.Margin = new Padding(4);
            textBoxTargetYLeft.Name = "textBoxTargetYLeft";
            textBoxTargetYLeft.Size = new Size(227, 30);
            textBoxTargetYLeft.TabIndex = 2;
            // 
            // textBoxTargetYRight
            // 
            textBoxTargetYRight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxTargetYRight.ForeColor = Color.Black;
            textBoxTargetYRight.Location = new Point(423, 4);
            textBoxTargetYRight.Margin = new Padding(4);
            textBoxTargetYRight.Name = "textBoxTargetYRight";
            textBoxTargetYRight.Size = new Size(228, 30);
            textBoxTargetYRight.TabIndex = 3;
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
            tableLayoutPanel2.Location = new Point(4, 159);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.Size = new Size(655, 38);
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
            textBoxStartY.Size = new Size(500, 30);
            textBoxStartY.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tableLayoutPanel4.Controls.Add(radioButtonLimitDeadly, 2, 0);
            tableLayoutPanel4.Controls.Add(radioButtonLimitSolid, 1, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 4, 0);
            tableLayoutPanel4.Controls.Add(integerTextBoxHeightLimit, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Right;
            tableLayoutPanel4.Location = new Point(181, 354);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(478, 38);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // radioButtonLimitDeadly
            // 
            radioButtonLimitDeadly.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButtonLimitDeadly.AutoCheck = false;
            radioButtonLimitDeadly.AutoSize = true;
            radioButtonLimitDeadly.Location = new Point(251, 5);
            radioButtonLimitDeadly.Margin = new Padding(4);
            radioButtonLimitDeadly.Name = "radioButtonLimitDeadly";
            radioButtonLimitDeadly.Size = new Size(114, 28);
            radioButtonLimitDeadly.TabIndex = 1;
            radioButtonLimitDeadly.TabStop = true;
            radioButtonLimitDeadly.Text = "Deadly";
            radioButtonLimitDeadly.UseVisualStyleBackColor = true;
            // 
            // radioButtonLimitSolid
            // 
            radioButtonLimitSolid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButtonLimitSolid.AutoCheck = false;
            radioButtonLimitSolid.AutoSize = true;
            radioButtonLimitSolid.Location = new Point(129, 5);
            radioButtonLimitSolid.Margin = new Padding(4);
            radioButtonLimitSolid.Name = "radioButtonLimitSolid";
            radioButtonLimitSolid.Size = new Size(114, 28);
            radioButtonLimitSolid.TabIndex = 0;
            radioButtonLimitSolid.TabStop = true;
            radioButtonLimitSolid.Text = "Solid";
            radioButtonLimitSolid.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(4, 7);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 24);
            label4.TabIndex = 2;
            label4.Text = "Height limit:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("宋体", 9F);
            label5.Location = new Point(433, 10);
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
            integerTextBoxHeightLimit.Location = new Point(373, 4);
            integerTextBoxHeightLimit.Margin = new Padding(4);
            integerTextBoxHeightLimit.Name = "integerTextBoxHeightLimit";
            integerTextBoxHeightLimit.Size = new Size(52, 30);
            integerTextBoxHeightLimit.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.Controls.Add(buttonYAlignSearch, 2, 0);
            tableLayoutPanel6.Controls.Add(buttonYAlignCancel, 2, 2);
            tableLayoutPanel6.Controls.Add(checkBoxCactus, 1, 0);
            tableLayoutPanel6.Controls.Add(checkBoxJumpCancel, 1, 1);
            tableLayoutPanel6.Controls.Add(checkBoxPlatformLanding, 1, 2);
            tableLayoutPanel6.Controls.Add(checkBoxSingleJumpOnly, 1, 3);
            tableLayoutPanel6.Controls.Add(checkBoxNoBunnyHop, 1, 4);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(4, 547);
            tableLayoutPanel6.Margin = new Padding(4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 5;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(655, 183);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // buttonYAlignSearch
            // 
            buttonYAlignSearch.Anchor = AnchorStyles.Right;
            buttonYAlignSearch.AutoSize = true;
            buttonYAlignSearch.Location = new Point(527, 4);
            buttonYAlignSearch.Margin = new Padding(4);
            buttonYAlignSearch.Name = "buttonYAlignSearch";
            buttonYAlignSearch.Padding = new Padding(12, 13, 12, 13);
            tableLayoutPanel6.SetRowSpan(buttonYAlignSearch, 2);
            buttonYAlignSearch.Size = new Size(124, 67);
            buttonYAlignSearch.TabIndex = 4;
            buttonYAlignSearch.Text = "Search →";
            buttonYAlignSearch.UseVisualStyleBackColor = true;
            // 
            // buttonYAlignCancel
            // 
            buttonYAlignCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonYAlignCancel.AutoSize = true;
            buttonYAlignCancel.Enabled = false;
            buttonYAlignCancel.Location = new Point(574, 79);
            buttonYAlignCancel.Margin = new Padding(4);
            buttonYAlignCancel.Name = "buttonYAlignCancel";
            tableLayoutPanel6.SetRowSpan(buttonYAlignCancel, 2);
            buttonYAlignCancel.Size = new Size(77, 41);
            buttonYAlignCancel.TabIndex = 5;
            buttonYAlignCancel.Text = "Cancel";
            buttonYAlignCancel.UseVisualStyleBackColor = true;
            buttonYAlignCancel.Visible = false;
            // 
            // checkBoxCactus
            // 
            checkBoxCactus.Anchor = AnchorStyles.Left;
            checkBoxCactus.AutoSize = true;
            checkBoxCactus.Location = new Point(69, 4);
            checkBoxCactus.Margin = new Padding(4);
            checkBoxCactus.Name = "checkBoxCactus";
            checkBoxCactus.Size = new Size(93, 28);
            checkBoxCactus.TabIndex = 6;
            checkBoxCactus.Text = "Cactus";
            checkBoxCactus.UseVisualStyleBackColor = true;
            // 
            // checkBoxJumpCancel
            // 
            checkBoxJumpCancel.Anchor = AnchorStyles.Left;
            checkBoxJumpCancel.AutoSize = true;
            checkBoxJumpCancel.Location = new Point(69, 41);
            checkBoxJumpCancel.Margin = new Padding(4);
            checkBoxJumpCancel.Name = "checkBoxJumpCancel";
            checkBoxJumpCancel.Size = new Size(145, 28);
            checkBoxJumpCancel.TabIndex = 7;
            checkBoxJumpCancel.Text = "Jump-cancel";
            checkBoxJumpCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlatformLanding
            // 
            checkBoxPlatformLanding.Anchor = AnchorStyles.Left;
            checkBoxPlatformLanding.AutoSize = true;
            checkBoxPlatformLanding.Location = new Point(69, 79);
            checkBoxPlatformLanding.Margin = new Padding(4);
            checkBoxPlatformLanding.Name = "checkBoxPlatformLanding";
            checkBoxPlatformLanding.Size = new Size(181, 28);
            checkBoxPlatformLanding.TabIndex = 8;
            checkBoxPlatformLanding.Text = "Platform landing";
            checkBoxPlatformLanding.UseVisualStyleBackColor = true;
            // 
            // checkBoxSingleJumpOnly
            // 
            checkBoxSingleJumpOnly.Anchor = AnchorStyles.Left;
            checkBoxSingleJumpOnly.AutoSize = true;
            checkBoxSingleJumpOnly.Checked = true;
            checkBoxSingleJumpOnly.CheckState = CheckState.Checked;
            checkBoxSingleJumpOnly.Location = new Point(69, 115);
            checkBoxSingleJumpOnly.Margin = new Padding(4);
            checkBoxSingleJumpOnly.Name = "checkBoxSingleJumpOnly";
            checkBoxSingleJumpOnly.Size = new Size(181, 28);
            checkBoxSingleJumpOnly.TabIndex = 9;
            checkBoxSingleJumpOnly.Text = "Single jump only";
            checkBoxSingleJumpOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoBunnyHop
            // 
            checkBoxNoBunnyHop.AutoSize = true;
            checkBoxNoBunnyHop.Checked = true;
            checkBoxNoBunnyHop.CheckState = CheckState.Checked;
            checkBoxNoBunnyHop.Location = new Point(69, 151);
            checkBoxNoBunnyHop.Margin = new Padding(4);
            checkBoxNoBunnyHop.Name = "checkBoxNoBunnyHop";
            checkBoxNoBunnyHop.Size = new Size(164, 28);
            checkBoxNoBunnyHop.TabIndex = 10;
            checkBoxNoBunnyHop.Text = "No bunny-hop";
            checkBoxNoBunnyHop.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(richTextBoxResult, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel7.Size = new Size(383, 971);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Dock = DockStyle.Fill;
            richTextBoxResult.Location = new Point(4, 54);
            richTextBoxResult.Margin = new Padding(4);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.ReadOnly = true;
            richTextBoxResult.Size = new Size(375, 713);
            richTextBoxResult.TabIndex = 4;
            richTextBoxResult.TabStop = false;
            richTextBoxResult.Text = "";
            // 
            // YAlignAdjustControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(4);
            Name = "YAlignAdjustControl";
            Size = new Size(1050, 971);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private RadioButton radioButtonStrategyFastest;
        private RadioButton radioButtonStrategyEasiest;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Label label3;
        private FloatStepperTextBox textBoxTargetYLeft;
        private FloatStepperTextBox textBoxTargetYRight;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private FloatStepperTextBox textBoxStartY;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton radioButtonLimitDeadly;
        private RadioButton radioButtonLimitSolid;
        private Label label4;
        private Label label5;
        private IntegerTextBox integerTextBoxHeightLimit;
        private TableLayoutPanel tableLayoutPanel6;
        private Button buttonYAlignSearch;
        private Button buttonYAlignCancel;
        private CheckBox checkBoxCactus;
        private CheckBox checkBoxJumpCancel;
        private CheckBox checkBoxPlatformLanding;
        private CheckBox checkBoxSingleJumpOnly;
        private CheckBox checkBoxNoBunnyHop;
        private TableLayoutPanel tableLayoutPanel7;
        private RichTextBox richTextBoxResult;
    }
}
