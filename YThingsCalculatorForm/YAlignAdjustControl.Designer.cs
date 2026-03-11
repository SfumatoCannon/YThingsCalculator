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
            richTextBoxResult = new RichTextBox();
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
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBoxResult, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(1336, 1254);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tableLayoutPanel5.Controls.Add(radioButtonStrategyFastest, 2, 0);
            tableLayoutPanel5.Controls.Add(radioButtonStrategyEasiest, 1, 0);
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(5, 519);
            tableLayoutPanel5.Margin = new Padding(5);
            tableLayoutPanel5.MinimumSize = new Size(700, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(872, 45);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // radioButtonStrategyFastest
            // 
            radioButtonStrategyFastest.Anchor = AnchorStyles.Left;
            radioButtonStrategyFastest.AutoSize = true;
            radioButtonStrategyFastest.Location = new Point(567, 5);
            radioButtonStrategyFastest.Margin = new Padding(5);
            radioButtonStrategyFastest.Name = "radioButtonStrategyFastest";
            radioButtonStrategyFastest.Size = new Size(125, 35);
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
            radioButtonStrategyEasiest.Location = new Point(380, 5);
            radioButtonStrategyEasiest.Margin = new Padding(5);
            radioButtonStrategyEasiest.Name = "radioButtonStrategyEasiest";
            radioButtonStrategyEasiest.Size = new Size(177, 35);
            radioButtonStrategyEasiest.TabIndex = 0;
            radioButtonStrategyEasiest.TabStop = true;
            radioButtonStrategyEasiest.Text = "Easiest";
            radioButtonStrategyEasiest.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(173, 7);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(197, 31);
            label6.TabIndex = 2;
            label6.Text = "Search strategy:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 2, 0);
            tableLayoutPanel3.Controls.Add(textBoxTargetYLeft, 1, 0);
            tableLayoutPanel3.Controls.Add(textBoxTargetYRight, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 267);
            tableLayoutPanel3.Margin = new Padding(5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(872, 48);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(5, 8);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 31);
            label2.TabIndex = 0;
            label2.Text = "Target Y:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(511, 8);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 31);
            label3.TabIndex = 2;
            label3.Text = "～";
            // 
            // textBoxTargetYLeft
            // 
            textBoxTargetYLeft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxTargetYLeft.ForeColor = Color.Black;
            textBoxTargetYLeft.Location = new Point(192, 5);
            textBoxTargetYLeft.Margin = new Padding(5);
            textBoxTargetYLeft.Name = "textBoxTargetYLeft";
            textBoxTargetYLeft.Size = new Size(309, 38);
            textBoxTargetYLeft.TabIndex = 2;
            // 
            // textBoxTargetYRight
            // 
            textBoxTargetYRight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxTargetYRight.ForeColor = Color.Black;
            textBoxTargetYRight.Location = new Point(558, 5);
            textBoxTargetYRight.Margin = new Padding(5);
            textBoxTargetYRight.Name = "textBoxTargetYRight";
            textBoxTargetYRight.Size = new Size(309, 38);
            textBoxTargetYRight.TabIndex = 3;
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
            tableLayoutPanel2.Location = new Point(5, 209);
            tableLayoutPanel2.Margin = new Padding(5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.Size = new Size(872, 48);
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
            textBoxStartY.Size = new Size(675, 38);
            textBoxStartY.TabIndex = 1;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Dock = DockStyle.Fill;
            richTextBoxResult.Location = new Point(925, 267);
            richTextBoxResult.Margin = new Padding(5);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(richTextBoxResult, 6);
            richTextBoxResult.Size = new Size(368, 675);
            richTextBoxResult.TabIndex = 2;
            richTextBoxResult.TabStop = false;
            richTextBoxResult.Text = "";
            richTextBoxResult.MouseDown += richTextBoxResult_MouseDown;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel4.Controls.Add(radioButtonLimitDeadly, 2, 0);
            tableLayoutPanel4.Controls.Add(radioButtonLimitSolid, 1, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 4, 0);
            tableLayoutPanel4.Controls.Add(integerTextBoxHeightLimit, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(5, 461);
            tableLayoutPanel4.Margin = new Padding(5);
            tableLayoutPanel4.MinimumSize = new Size(700, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel4.Size = new Size(872, 48);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // radioButtonLimitDeadly
            // 
            radioButtonLimitDeadly.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButtonLimitDeadly.AutoCheck = false;
            radioButtonLimitDeadly.AutoSize = true;
            radioButtonLimitDeadly.Location = new Point(535, 6);
            radioButtonLimitDeadly.Margin = new Padding(5);
            radioButtonLimitDeadly.Name = "radioButtonLimitDeadly";
            radioButtonLimitDeadly.Size = new Size(145, 35);
            radioButtonLimitDeadly.TabIndex = 1;
            radioButtonLimitDeadly.TabStop = true;
            radioButtonLimitDeadly.Text = "Deadly";
            radioButtonLimitDeadly.UseVisualStyleBackColor = true;
            radioButtonLimitDeadly.Click += radioButtonLimitDeadly_Click;
            // 
            // radioButtonLimitSolid
            // 
            radioButtonLimitSolid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButtonLimitSolid.AutoCheck = false;
            radioButtonLimitSolid.AutoSize = true;
            radioButtonLimitSolid.Location = new Point(380, 6);
            radioButtonLimitSolid.Margin = new Padding(5);
            radioButtonLimitSolid.Name = "radioButtonLimitSolid";
            radioButtonLimitSolid.Size = new Size(145, 35);
            radioButtonLimitSolid.TabIndex = 0;
            radioButtonLimitSolid.TabStop = true;
            radioButtonLimitSolid.Text = "Solid";
            radioButtonLimitSolid.UseVisualStyleBackColor = true;
            radioButtonLimitSolid.Click += radioButtonLimitSolid_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(216, 8);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 31);
            label4.TabIndex = 2;
            label4.Text = "Height limit:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("宋体", 9F);
            label5.Location = new Point(815, 12);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 24);
            label5.TabIndex = 3;
            label5.Text = "px";
            // 
            // integerTextBoxHeightLimit
            // 
            integerTextBoxHeightLimit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            integerTextBoxHeightLimit.Enabled = false;
            integerTextBoxHeightLimit.ForeColor = Color.Black;
            integerTextBoxHeightLimit.Location = new Point(690, 5);
            integerTextBoxHeightLimit.Margin = new Padding(5);
            integerTextBoxHeightLimit.Name = "integerTextBoxHeightLimit";
            integerTextBoxHeightLimit.Size = new Size(115, 38);
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
            tableLayoutPanel6.Location = new Point(5, 710);
            tableLayoutPanel6.Margin = new Padding(5);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 5;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(872, 232);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // buttonYAlignSearch
            // 
            buttonYAlignSearch.Anchor = AnchorStyles.Right;
            buttonYAlignSearch.AutoSize = true;
            buttonYAlignSearch.Location = new Point(668, 5);
            buttonYAlignSearch.Margin = new Padding(5);
            buttonYAlignSearch.Name = "buttonYAlignSearch";
            buttonYAlignSearch.Padding = new Padding(15, 17, 15, 17);
            tableLayoutPanel6.SetRowSpan(buttonYAlignSearch, 2);
            buttonYAlignSearch.Size = new Size(199, 87);
            buttonYAlignSearch.TabIndex = 4;
            buttonYAlignSearch.Text = "Search →";
            buttonYAlignSearch.UseVisualStyleBackColor = true;
            buttonYAlignSearch.Click += buttonYAlignSearch_Click;
            // 
            // buttonYAlignCancel
            // 
            buttonYAlignCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonYAlignCancel.AutoSize = true;
            buttonYAlignCancel.Enabled = false;
            buttonYAlignCancel.Location = new Point(740, 102);
            buttonYAlignCancel.Margin = new Padding(5);
            buttonYAlignCancel.Name = "buttonYAlignCancel";
            tableLayoutPanel6.SetRowSpan(buttonYAlignCancel, 2);
            buttonYAlignCancel.Size = new Size(127, 53);
            buttonYAlignCancel.TabIndex = 5;
            buttonYAlignCancel.Text = "Cancel";
            buttonYAlignCancel.UseVisualStyleBackColor = true;
            buttonYAlignCancel.Visible = false;
            buttonYAlignCancel.Click += buttonYAlignCancel_Click;
            // 
            // checkBoxCactus
            // 
            checkBoxCactus.Anchor = AnchorStyles.Left;
            checkBoxCactus.AutoSize = true;
            checkBoxCactus.Location = new Point(92, 5);
            checkBoxCactus.Margin = new Padding(5);
            checkBoxCactus.Name = "checkBoxCactus";
            checkBoxCactus.Size = new Size(122, 35);
            checkBoxCactus.TabIndex = 6;
            checkBoxCactus.Text = "Cactus";
            checkBoxCactus.UseVisualStyleBackColor = true;
            // 
            // checkBoxJumpCancel
            // 
            checkBoxJumpCancel.Anchor = AnchorStyles.Left;
            checkBoxJumpCancel.AutoSize = true;
            checkBoxJumpCancel.Location = new Point(92, 53);
            checkBoxJumpCancel.Margin = new Padding(5);
            checkBoxJumpCancel.Name = "checkBoxJumpCancel";
            checkBoxJumpCancel.Size = new Size(190, 35);
            checkBoxJumpCancel.TabIndex = 7;
            checkBoxJumpCancel.Text = "Jump-cancel";
            checkBoxJumpCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlatformLanding
            // 
            checkBoxPlatformLanding.Anchor = AnchorStyles.Left;
            checkBoxPlatformLanding.AutoSize = true;
            checkBoxPlatformLanding.Location = new Point(92, 102);
            checkBoxPlatformLanding.Margin = new Padding(5);
            checkBoxPlatformLanding.Name = "checkBoxPlatformLanding";
            checkBoxPlatformLanding.Size = new Size(235, 35);
            checkBoxPlatformLanding.TabIndex = 8;
            checkBoxPlatformLanding.Text = "Platform landing";
            checkBoxPlatformLanding.UseVisualStyleBackColor = true;
            checkBoxPlatformLanding.CheckedChanged += checkBoxPlatformLanding_CheckedChanged;
            // 
            // checkBoxSingleJumpOnly
            // 
            checkBoxSingleJumpOnly.Anchor = AnchorStyles.Left;
            checkBoxSingleJumpOnly.AutoSize = true;
            checkBoxSingleJumpOnly.Checked = true;
            checkBoxSingleJumpOnly.CheckState = CheckState.Checked;
            checkBoxSingleJumpOnly.Location = new Point(92, 147);
            checkBoxSingleJumpOnly.Margin = new Padding(5);
            checkBoxSingleJumpOnly.Name = "checkBoxSingleJumpOnly";
            checkBoxSingleJumpOnly.Size = new Size(237, 35);
            checkBoxSingleJumpOnly.TabIndex = 9;
            checkBoxSingleJumpOnly.Text = "Single jump only";
            checkBoxSingleJumpOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoBunnyHop
            // 
            checkBoxNoBunnyHop.AutoSize = true;
            checkBoxNoBunnyHop.Checked = true;
            checkBoxNoBunnyHop.CheckState = CheckState.Checked;
            checkBoxNoBunnyHop.Location = new Point(92, 192);
            checkBoxNoBunnyHop.Margin = new Padding(5);
            checkBoxNoBunnyHop.Name = "checkBoxNoBunnyHop";
            checkBoxNoBunnyHop.Size = new Size(216, 35);
            checkBoxNoBunnyHop.TabIndex = 10;
            checkBoxNoBunnyHop.Text = "No bunny-hop";
            checkBoxNoBunnyHop.UseVisualStyleBackColor = true;
            checkBoxNoBunnyHop.CheckedChanged += checkBoxNoBunnyHop_CheckedChanged;
            // 
            // YAlignAdjustControl
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5);
            Name = "YAlignAdjustControl";
            Size = new Size(1336, 1254);
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
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FloatStepperTextBox textBoxStartY;
        private FloatStepperTextBox textBoxTargetYLeft;
        private FloatStepperTextBox textBoxTargetYRight;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton radioButtonLimitSolid;
        private System.Windows.Forms.RadioButton radioButtonLimitDeadly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private IntegerTextBox integerTextBoxHeightLimit;
        private System.Windows.Forms.Button buttonYAlignSearch;
        private System.Windows.Forms.Button buttonYAlignCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton radioButtonStrategyFastest;
        private System.Windows.Forms.RadioButton radioButtonStrategyEasiest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox checkBoxCactus;
        private System.Windows.Forms.CheckBox checkBoxJumpCancel;
        private System.Windows.Forms.CheckBox checkBoxPlatformLanding;
        private System.Windows.Forms.CheckBox checkBoxSingleJumpOnly;
        private System.Windows.Forms.CheckBox checkBoxNoBunnyHop;
    }
}
