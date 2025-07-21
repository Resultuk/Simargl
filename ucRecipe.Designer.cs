namespace Simargl
{
    partial class ucRecipe
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            cmnPeriod = new DataGridViewTextBoxColumn();
            cmnCH1 = new DataGridViewTextBoxColumn();
            cmnCH2 = new DataGridViewTextBoxColumn();
            cmnCH3 = new DataGridViewTextBoxColumn();
            cmnCH4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            tBSwtc_ch = new TextBox();
            cbMode = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            nudLoops = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLoops).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 312);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cmnPeriod, cmnCH1, cmnCH2, cmnCH3, cmnCH4 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 100;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 22;
            dataGridView1.Size = new Size(519, 278);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // cmnPeriod
            // 
            cmnPeriod.HeaderText = "Period";
            cmnPeriod.Name = "cmnPeriod";
            cmnPeriod.Width = 60;
            // 
            // cmnCH1
            // 
            cmnCH1.HeaderText = "CH1";
            cmnCH1.Name = "cmnCH1";
            cmnCH1.Width = 40;
            // 
            // cmnCH2
            // 
            cmnCH2.HeaderText = "CH2";
            cmnCH2.Name = "cmnCH2";
            cmnCH2.Width = 40;
            // 
            // cmnCH3
            // 
            cmnCH3.HeaderText = "CH3";
            cmnCH3.Name = "cmnCH3";
            cmnCH3.Width = 40;
            // 
            // cmnCH4
            // 
            cmnCH4.HeaderText = "CH4";
            cmnCH4.Name = "cmnCH4";
            cmnCH4.Width = 40;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tBSwtc_ch, 2, 0);
            tableLayoutPanel1.Controls.Add(cbMode, 1, 0);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 3, 0);
            tableLayoutPanel1.Controls.Add(nudLoops, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(519, 34);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tBSwtc_ch
            // 
            tBSwtc_ch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tBSwtc_ch.Location = new Point(253, 5);
            tBSwtc_ch.Margin = new Padding(3, 2, 3, 3);
            tBSwtc_ch.Name = "tBSwtc_ch";
            tBSwtc_ch.Size = new Size(94, 23);
            tBSwtc_ch.TabIndex = 19;
            tBSwtc_ch.TextAlign = HorizontalAlignment.Center;
            tBSwtc_ch.TextChanged += tBSwtc_ch_TextChanged;
            tBSwtc_ch.Enter += tBSwtc_ch_Enter;
            tBSwtc_ch.Leave += tBSwtc_ch_Leave;
            // 
            // cbMode
            // 
            cbMode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbMode.FormattingEnabled = true;
            cbMode.Items.AddRange(new object[] { "Disable", "Manual", "Auto(Manual)", "Auto" });
            cbMode.Location = new Point(153, 5);
            cbMode.Margin = new Padding(3, 2, 3, 3);
            cbMode.Name = "cbMode";
            cbMode.Size = new Size(94, 23);
            cbMode.TabIndex = 14;
            cbMode.SelectedIndexChanged += cbMode_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(3, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(144, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Phase-1", "Phase-2", "Phase-3", "Phase-4", "Phase-5", "Phase-6", "Phase-7", "Phase-8", "Phase-9", "Phase-10", "Phase-11", "Phase-12", "Phase-13", "Phase-14", "Phase-15", "Phase-16" });
            comboBox1.Location = new Point(353, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(69, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // nudLoops
            // 
            nudLoops.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudLoops.Location = new Point(428, 5);
            nudLoops.Name = "nudLoops";
            nudLoops.Size = new Size(69, 23);
            nudLoops.TabIndex = 4;
            nudLoops.TextAlign = HorizontalAlignment.Center;
            nudLoops.ValueChanged += nudLoops_ValueChanged;
            // 
            // ucRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucRecipe";
            Size = new Size(519, 312);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLoops).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cmnPeriod;
        private DataGridViewTextBoxColumn cmnCH1;
        private DataGridViewTextBoxColumn cmnCH2;
        private DataGridViewTextBoxColumn cmnCH3;
        private DataGridViewTextBoxColumn cmnCH4;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private NumericUpDown nudLoops;
        private ComboBox cbMode;
        private TextBox tBSwtc_ch;
    }
}
