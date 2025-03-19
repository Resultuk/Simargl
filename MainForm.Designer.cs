using Aga.Controls.Tree;

namespace Simargl
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            mainTree = new TreeViewAdv();
            tcName = new TreeColumn();
            contextMenu = new ContextMenuStrip(components);
            tsmiReadIllum = new ToolStripMenuItem();
            tsmiReadWater = new ToolStripMenuItem();
            tsmiWriteIllum = new ToolStripMenuItem();
            tsmiWriteWater = new ToolStripMenuItem();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            cmnPeriod = new DataGridViewTextBoxColumn();
            cmnCH1 = new DataGridViewTextBoxColumn();
            cmnCH2 = new DataGridViewTextBoxColumn();
            cmnCH3 = new DataGridViewTextBoxColumn();
            cmnCH4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            labSelectedDevice = new Label();
            gbIllumination = new GroupBox();
            toolStrip3 = new ToolStrip();
            tsbReadIllum = new ToolStripButton();
            tsbWriteIllum = new ToolStripButton();
            gbWatering = new GroupBox();
            ucWatering1 = new ucWatering();
            toolStrip1 = new ToolStrip();
            tsbReadWater = new ToolStripButton();
            tsbWriteWater = new ToolStripButton();
            splitter2 = new Splitter();
            panel2 = new Panel();
            gbIdentity = new GroupBox();
            ucidNumbers1 = new ucIDNumbers();
            toolStrip2 = new ToolStrip();
            tsbReadIDs = new ToolStripButton();
            tsbWriteID = new ToolStripButton();
            gbSelected = new GroupBox();
            contextMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gbIllumination.SuspendLayout();
            toolStrip3.SuspendLayout();
            gbWatering.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            gbIdentity.SuspendLayout();
            toolStrip2.SuspendLayout();
            gbSelected.SuspendLayout();
            SuspendLayout();
            // 
            // mainTree
            // 
            mainTree.AutoHeaderHeight = true;
            mainTree.BackColor = SystemColors.Window;
            mainTree.Columns.Add(tcName);
            mainTree.ContextMenuStrip = contextMenu;
            mainTree.Dock = DockStyle.Left;
            mainTree.Location = new Point(0, 0);
            mainTree.Name = "mainTree";
            mainTree.Size = new Size(481, 496);
            mainTree.TabIndex = 0;
            mainTree.Text = "treeViewAdv1";
            mainTree.UseColumns = true;
            mainTree.SelectionChanged += mainTree_SelectionChanged;
            // 
            // tcName
            // 
            tcName.TextAlign = HorizontalAlignment.Center;
            tcName.Width = 150;
            // 
            // contextMenu
            // 
            contextMenu.Items.AddRange(new ToolStripItem[] { tsmiReadIllum, tsmiReadWater, tsmiWriteIllum, tsmiWriteWater });
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new Size(170, 92);
            // 
            // tsmiReadIllum
            // 
            tsmiReadIllum.Name = "tsmiReadIllum";
            tsmiReadIllum.Size = new Size(169, 22);
            tsmiReadIllum.Text = "Read Illumination";
            tsmiReadIllum.Click += tsmiRead_Click;
            // 
            // tsmiReadWater
            // 
            tsmiReadWater.Name = "tsmiReadWater";
            tsmiReadWater.Size = new Size(169, 22);
            tsmiReadWater.Text = "Read Watering";
            tsmiReadWater.Click += tsmiReadWater_Click;
            // 
            // tsmiWriteIllum
            // 
            tsmiWriteIllum.Name = "tsmiWriteIllum";
            tsmiWriteIllum.Size = new Size(169, 22);
            tsmiWriteIllum.Text = "Write Illumination";
            tsmiWriteIllum.Click += tsmiWrite_Click;
            // 
            // tsmiWriteWater
            // 
            tsmiWriteWater.Name = "tsmiWriteWater";
            tsmiWriteWater.Size = new Size(169, 22);
            tsmiWriteWater.Text = "Write Watering";
            tsmiWriteWater.Click += tsmiWriteWater_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 335);
            panel1.TabIndex = 1;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersWidth = 100;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowTemplate.Height = 22;
            dataGridView1.Size = new Size(572, 301);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
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
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.23404F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.7659569F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(572, 34);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(3, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(365, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Phase-1", "Phase-2", "Phase-3", "Phase-4", "Phase-5", "Phase-6", "Phase-7", "Phase-8", "Phase-9", "Phase-10", "Phase-11", "Phase-12", "Phase-13", "Phase-14", "Phase-15", "Phase-16" });
            comboBox1.Location = new Point(374, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(103, 23);
            comboBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Location = new Point(483, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(86, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // labSelectedDevice
            // 
            labSelectedDevice.Dock = DockStyle.Fill;
            labSelectedDevice.Location = new Point(3, 19);
            labSelectedDevice.Name = "labSelectedDevice";
            labSelectedDevice.Size = new Size(572, 25);
            labSelectedDevice.TabIndex = 5;
            labSelectedDevice.Text = "label1";
            labSelectedDevice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbIllumination
            // 
            gbIllumination.Controls.Add(panel1);
            gbIllumination.Controls.Add(toolStrip3);
            gbIllumination.Dock = DockStyle.Top;
            gbIllumination.Location = new Point(0, 255);
            gbIllumination.Name = "gbIllumination";
            gbIllumination.Size = new Size(578, 382);
            gbIllumination.TabIndex = 3;
            gbIllumination.TabStop = false;
            gbIllumination.Text = "Illumination";
            // 
            // toolStrip3
            // 
            toolStrip3.Items.AddRange(new ToolStripItem[] { tsbReadIllum, tsbWriteIllum });
            toolStrip3.Location = new Point(3, 19);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(572, 25);
            toolStrip3.TabIndex = 2;
            toolStrip3.Text = "toolStrip3";
            // 
            // tsbReadIllum
            // 
            tsbReadIllum.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbReadIllum.Image = Res.read_32;
            tsbReadIllum.ImageTransparentColor = Color.Magenta;
            tsbReadIllum.Name = "tsbReadIllum";
            tsbReadIllum.Size = new Size(23, 22);
            tsbReadIllum.Text = "Read";
            tsbReadIllum.ToolTipText = "Read data from device";
            tsbReadIllum.Click += tsbReadIllum_Click;
            // 
            // tsbWriteIllum
            // 
            tsbWriteIllum.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbWriteIllum.Image = Res.write_32;
            tsbWriteIllum.ImageTransparentColor = Color.Magenta;
            tsbWriteIllum.Name = "tsbWriteIllum";
            tsbWriteIllum.Size = new Size(23, 22);
            tsbWriteIllum.Text = "Write";
            tsbWriteIllum.ToolTipText = "Write data to the device";
            tsbWriteIllum.Click += tsbWriteIllum_Click;
            // 
            // gbWatering
            // 
            gbWatering.Controls.Add(ucWatering1);
            gbWatering.Controls.Add(toolStrip1);
            gbWatering.Dock = DockStyle.Top;
            gbWatering.Location = new Point(0, 47);
            gbWatering.Name = "gbWatering";
            gbWatering.Size = new Size(578, 208);
            gbWatering.TabIndex = 4;
            gbWatering.TabStop = false;
            gbWatering.Text = "Watering";
            // 
            // ucWatering1
            // 
            ucWatering1.Dock = DockStyle.Top;
            ucWatering1.Location = new Point(3, 44);
            ucWatering1.Name = "ucWatering1";
            ucWatering1.Size = new Size(572, 153);
            ucWatering1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbReadWater, tsbWriteWater });
            toolStrip1.Location = new Point(3, 19);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(572, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbReadWater
            // 
            tsbReadWater.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbReadWater.Image = Res.read_32;
            tsbReadWater.ImageTransparentColor = Color.Magenta;
            tsbReadWater.Name = "tsbReadWater";
            tsbReadWater.Size = new Size(23, 22);
            tsbReadWater.Text = "Read";
            tsbReadWater.ToolTipText = "Read data from device";
            tsbReadWater.Click += tsbReadWater_Click;
            // 
            // tsbWriteWater
            // 
            tsbWriteWater.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbWriteWater.Image = Res.write_32;
            tsbWriteWater.ImageTransparentColor = Color.Magenta;
            tsbWriteWater.Name = "tsbWriteWater";
            tsbWriteWater.Size = new Size(23, 22);
            tsbWriteWater.Text = "Write";
            tsbWriteWater.ToolTipText = "Write data to the device";
            tsbWriteWater.Click += tsbWriteWater_Click;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(481, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(10, 496);
            splitter2.TabIndex = 5;
            splitter2.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(gbIdentity);
            panel2.Controls.Add(gbIllumination);
            panel2.Controls.Add(gbWatering);
            panel2.Controls.Add(gbSelected);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(491, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 496);
            panel2.TabIndex = 6;
            // 
            // gbIdentity
            // 
            gbIdentity.Controls.Add(ucidNumbers1);
            gbIdentity.Controls.Add(toolStrip2);
            gbIdentity.Dock = DockStyle.Top;
            gbIdentity.Location = new Point(0, 637);
            gbIdentity.Name = "gbIdentity";
            gbIdentity.Size = new Size(578, 622);
            gbIdentity.TabIndex = 6;
            gbIdentity.TabStop = false;
            gbIdentity.Text = "Devices";
            // 
            // ucidNumbers1
            // 
            ucidNumbers1.Dock = DockStyle.Fill;
            ucidNumbers1.Location = new Point(3, 44);
            ucidNumbers1.Name = "ucidNumbers1";
            ucidNumbers1.Size = new Size(572, 575);
            ucidNumbers1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { tsbReadIDs, tsbWriteID });
            toolStrip2.Location = new Point(3, 19);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(572, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // tsbReadIDs
            // 
            tsbReadIDs.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbReadIDs.Image = Res.read_32;
            tsbReadIDs.ImageTransparentColor = Color.Magenta;
            tsbReadIDs.Name = "tsbReadIDs";
            tsbReadIDs.Size = new Size(23, 22);
            tsbReadIDs.Text = "Read";
            tsbReadIDs.ToolTipText = "Read data from device";
            tsbReadIDs.Click += tsbReadIDs_Click;
            // 
            // tsbWriteID
            // 
            tsbWriteID.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbWriteID.Image = Res.write_32;
            tsbWriteID.ImageTransparentColor = Color.Magenta;
            tsbWriteID.Name = "tsbWriteID";
            tsbWriteID.Size = new Size(23, 22);
            tsbWriteID.Text = "Write";
            tsbWriteID.ToolTipText = "Write data to the device";
            tsbWriteID.Click += tsbWriteID_Click;
            // 
            // gbSelected
            // 
            gbSelected.Controls.Add(labSelectedDevice);
            gbSelected.Dock = DockStyle.Top;
            gbSelected.Location = new Point(0, 0);
            gbSelected.Name = "gbSelected";
            gbSelected.Size = new Size(578, 47);
            gbSelected.TabIndex = 5;
            gbSelected.TabStop = false;
            gbSelected.Text = "Information";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 496);
            Controls.Add(panel2);
            Controls.Add(splitter2);
            Controls.Add(mainTree);
            Name = "MainForm";
            Text = "Simargl";
            contextMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gbIllumination.ResumeLayout(false);
            gbIllumination.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            gbWatering.ResumeLayout(false);
            gbWatering.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            gbIdentity.ResumeLayout(false);
            gbIdentity.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            gbSelected.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeViewAdv mainTree;
        private TreeColumn tcName;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem tsmiReadIllum;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label labSelectedDevice;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn cmnPeriod;
        private DataGridViewTextBoxColumn cmnCH1;
        private DataGridViewTextBoxColumn cmnCH2;
        private DataGridViewTextBoxColumn cmnCH3;
        private DataGridViewTextBoxColumn cmnCH4;
        private ToolStripMenuItem tsmiWriteIllum;
        private GroupBox gbIllumination;
        private ToolStripMenuItem tsmiReadWater;
        private GroupBox gbWatering;
        private ucWatering ucWatering1;
        private Splitter splitter2;
        private ToolStripMenuItem tsmiWriteWater;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbReadWater;
        private ToolStripButton tsbWriteWater;
        private Panel panel2;
        private GroupBox gbSelected;
        private GroupBox gbIdentity;
        private ucIDNumbers ucidNumbers1;
        private ToolStrip toolStrip2;
        private ToolStripButton tsbReadIDs;
        private ToolStripButton tsbWriteID;
        private ToolStrip toolStrip3;
        private ToolStripButton tsbReadIllum;
        private ToolStripButton tsbWriteIllum;
    }
}
