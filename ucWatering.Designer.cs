namespace Simargl
{
    partial class ucWatering
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            dtpEnd_ch = new DateTimePicker();
            cbMode = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpStart_ch = new DateTimePicker();
            tBLoop_ch = new TextBox();
            tBWork_ch = new TextBox();
            tBSwtc_ch = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbLevelMin1 = new TextBox();
            tbLevelMax1 = new TextBox();
            cbDontStop = new CheckBox();
            chbLevel1 = new CheckBox();
            nudLevelNetAddr1 = new NumericUpDown();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLevelNetAddr1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 6;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Controls.Add(dtpEnd_ch, 1, 2);
            tableLayoutPanel.Controls.Add(cbMode, 1, 0);
            tableLayoutPanel.Controls.Add(label5, 0, 0);
            tableLayoutPanel.Controls.Add(label2, 0, 1);
            tableLayoutPanel.Controls.Add(label3, 0, 2);
            tableLayoutPanel.Controls.Add(label4, 0, 3);
            tableLayoutPanel.Controls.Add(label6, 0, 4);
            tableLayoutPanel.Controls.Add(label7, 0, 5);
            tableLayoutPanel.Controls.Add(dtpStart_ch, 1, 1);
            tableLayoutPanel.Controls.Add(tBLoop_ch, 1, 3);
            tableLayoutPanel.Controls.Add(tBWork_ch, 1, 4);
            tableLayoutPanel.Controls.Add(tBSwtc_ch, 1, 5);
            tableLayoutPanel.Controls.Add(label1, 2, 3);
            tableLayoutPanel.Controls.Add(label8, 2, 4);
            tableLayoutPanel.Controls.Add(label9, 2, 5);
            tableLayoutPanel.Controls.Add(tbLevelMin1, 3, 4);
            tableLayoutPanel.Controls.Add(tbLevelMax1, 3, 5);
            tableLayoutPanel.Controls.Add(cbDontStop, 4, 2);
            tableLayoutPanel.Controls.Add(chbLevel1, 4, 3);
            tableLayoutPanel.Controls.Add(nudLevelNetAddr1, 3, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 7;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(325, 153);
            tableLayoutPanel.TabIndex = 1;
            // 
            // dtpEnd_ch
            // 
            dtpEnd_ch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(dtpEnd_ch, 3);
            dtpEnd_ch.CustomFormat = "yyyy-MM-dd HH:mm:ss ";
            dtpEnd_ch.Format = DateTimePickerFormat.Custom;
            dtpEnd_ch.Location = new Point(83, 51);
            dtpEnd_ch.Margin = new Padding(3, 0, 3, 0);
            dtpEnd_ch.Name = "dtpEnd_ch";
            dtpEnd_ch.Size = new Size(214, 23);
            dtpEnd_ch.TabIndex = 15;
            dtpEnd_ch.ValueChanged += dtpEnd_ch_ValueChanged;
            // 
            // cbMode
            // 
            cbMode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(cbMode, 2);
            cbMode.FormattingEnabled = true;
            cbMode.Items.AddRange(new object[] { "Disable", "Manual", "Auto(Manual)", "Auto" });
            cbMode.Location = new Point(83, 1);
            cbMode.Margin = new Padding(3, 1, 3, 3);
            cbMode.Name = "cbMode";
            cbMode.Size = new Size(154, 23);
            cbMode.TabIndex = 13;
            cbMode.SelectedIndexChanged += cbMode_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(3, 1);
            label5.Margin = new Padding(3, 1, 3, 1);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 4;
            label5.Text = "Mode";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(3, 26);
            label2.Margin = new Padding(3, 1, 3, 1);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 4;
            label2.Text = "Beginning";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(3, 51);
            label3.Margin = new Padding(3, 1, 3, 1);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 4;
            label3.Text = "Ending";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(3, 76);
            label4.Margin = new Padding(3, 1, 3, 1);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 4;
            label4.Text = "Interval";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(3, 101);
            label6.Margin = new Padding(3, 1, 3, 1);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 4;
            label6.Text = "Work";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(3, 126);
            label7.Margin = new Padding(3, 1, 3, 1);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 4;
            label7.Text = "Switch";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpStart_ch
            // 
            dtpStart_ch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(dtpStart_ch, 4);
            dtpStart_ch.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpStart_ch.Format = DateTimePickerFormat.Custom;
            dtpStart_ch.Location = new Point(83, 26);
            dtpStart_ch.Margin = new Padding(3, 0, 3, 0);
            dtpStart_ch.Name = "dtpStart_ch";
            dtpStart_ch.Size = new Size(234, 23);
            dtpStart_ch.TabIndex = 14;
            dtpStart_ch.ValueChanged += dtpStart_ch_ValueChanged;
            // 
            // tBLoop_ch
            // 
            tBLoop_ch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tBLoop_ch.Location = new Point(83, 76);
            tBLoop_ch.Margin = new Padding(3, 1, 3, 3);
            tBLoop_ch.Name = "tBLoop_ch";
            tBLoop_ch.Size = new Size(74, 23);
            tBLoop_ch.TabIndex = 16;
            tBLoop_ch.TextAlign = HorizontalAlignment.Center;
            tBLoop_ch.TextChanged += tBLoop_ch_TextChanged;
            // 
            // tBWork_ch
            // 
            tBWork_ch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tBWork_ch.CausesValidation = false;
            tBWork_ch.Location = new Point(83, 101);
            tBWork_ch.Margin = new Padding(3, 1, 3, 3);
            tBWork_ch.Name = "tBWork_ch";
            tBWork_ch.Size = new Size(74, 23);
            tBWork_ch.TabIndex = 17;
            tBWork_ch.TextAlign = HorizontalAlignment.Center;
            tBWork_ch.TextChanged += tBLoop_ch_TextChanged;
            // 
            // tBSwtc_ch
            // 
            tBSwtc_ch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tBSwtc_ch.Location = new Point(83, 126);
            tBSwtc_ch.Margin = new Padding(3, 1, 3, 3);
            tBSwtc_ch.Name = "tBSwtc_ch";
            tBSwtc_ch.Size = new Size(74, 23);
            tBSwtc_ch.TabIndex = 18;
            tBSwtc_ch.TextAlign = HorizontalAlignment.Center;
            tBSwtc_ch.TextChanged += tBLoop_ch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(163, 76);
            label1.Margin = new Padding(3, 1, 3, 1);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 20;
            label1.Text = "Address";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(163, 101);
            label8.Margin = new Padding(3, 1, 3, 1);
            label8.Name = "label8";
            label8.Size = new Size(74, 23);
            label8.TabIndex = 20;
            label8.Text = "Min";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(163, 126);
            label9.Margin = new Padding(3, 1, 3, 1);
            label9.Name = "label9";
            label9.Size = new Size(74, 23);
            label9.TabIndex = 20;
            label9.Text = "Max";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbLevelMin1
            // 
            tbLevelMin1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(tbLevelMin1, 2);
            tbLevelMin1.Location = new Point(243, 102);
            tbLevelMin1.Margin = new Padding(3, 2, 3, 2);
            tbLevelMin1.Name = "tbLevelMin1";
            tbLevelMin1.Size = new Size(74, 23);
            tbLevelMin1.TabIndex = 21;
            tbLevelMin1.TextAlign = HorizontalAlignment.Center;
            tbLevelMin1.TextChanged += tBLoop_ch_TextChanged;
            // 
            // tbLevelMax1
            // 
            tbLevelMax1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(tbLevelMax1, 2);
            tbLevelMax1.Location = new Point(243, 127);
            tbLevelMax1.Margin = new Padding(3, 2, 3, 2);
            tbLevelMax1.Name = "tbLevelMax1";
            tbLevelMax1.Size = new Size(74, 23);
            tbLevelMax1.TabIndex = 22;
            tbLevelMax1.TextAlign = HorizontalAlignment.Center;
            tbLevelMax1.TextChanged += tBLoop_ch_TextChanged;
            // 
            // cbDontStop
            // 
            cbDontStop.CheckAlign = ContentAlignment.MiddleCenter;
            cbDontStop.Dock = DockStyle.Fill;
            cbDontStop.Location = new Point(303, 53);
            cbDontStop.Name = "cbDontStop";
            cbDontStop.Size = new Size(14, 19);
            cbDontStop.TabIndex = 0;
            cbDontStop.UseVisualStyleBackColor = true;
            cbDontStop.CheckedChanged += cbDontStop_CheckedChanged;
            // 
            // chbLevel1
            // 
            chbLevel1.AutoSize = true;
            chbLevel1.CheckAlign = ContentAlignment.MiddleCenter;
            chbLevel1.Dock = DockStyle.Fill;
            chbLevel1.Location = new Point(303, 78);
            chbLevel1.Name = "chbLevel1";
            chbLevel1.Size = new Size(14, 19);
            chbLevel1.TabIndex = 23;
            chbLevel1.UseVisualStyleBackColor = true;
            chbLevel1.CheckedChanged += chbLevel1_CheckedChanged;
            // 
            // nudLevelNetAddr1
            // 
            nudLevelNetAddr1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudLevelNetAddr1.Enabled = false;
            nudLevelNetAddr1.Location = new Point(243, 77);
            nudLevelNetAddr1.Margin = new Padding(3, 2, 3, 2);
            nudLevelNetAddr1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudLevelNetAddr1.Minimum = new decimal(new int[] { 129, 0, 0, 0 });
            nudLevelNetAddr1.Name = "nudLevelNetAddr1";
            nudLevelNetAddr1.Size = new Size(54, 23);
            nudLevelNetAddr1.TabIndex = 24;
            nudLevelNetAddr1.TextAlign = HorizontalAlignment.Center;
            nudLevelNetAddr1.Value = new decimal(new int[] { 129, 0, 0, 0 });
            nudLevelNetAddr1.ValueChanged += nudLevelNetAddr1_ValueChanged;
            // 
            // ucWatering
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Name = "ucWatering";
            Size = new Size(325, 153);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLevelNetAddr1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private ComboBox cbMode;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpStart_ch;
        private TextBox tBLoop_ch;
        private TextBox tBWork_ch;
        private TextBox tBSwtc_ch;
        private DateTimePicker dtpEnd_ch;
        private CheckBox cbDontStop;
        private Label label1;
        private Label label8;
        private Label label9;
        private TextBox tbLevelMin1;
        private TextBox tbLevelMax1;
        private CheckBox chbLevel1;
        private NumericUpDown nudLevelNetAddr1;
    }
}
