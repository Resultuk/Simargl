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
            mainTree = new TreeViewAdv();
            tcName = new TreeColumn();
            tcControl = new TreeColumn();
            tcStatus = new TreeColumn();
            contextMenu = new ContextMenuStrip(components);
            tsmiReadIllum = new ToolStripMenuItem();
            tsmiReadWater = new ToolStripMenuItem();
            tsmiWriteIllum = new ToolStripMenuItem();
            tsmiWriteWater = new ToolStripMenuItem();
            labSelectedDevice = new Label();
            gbIllumination = new GroupBox();
            ucRecipe1 = new ucRecipe();
            toolStrip3 = new ToolStrip();
            tsbReadIllum = new ToolStripButton();
            tsbWriteIllum = new ToolStripButton();
            gbWatering = new GroupBox();
            ucWatering1 = new ucWatering();
            toolStrip1 = new ToolStrip();
            tsbReadWater = new ToolStripButton();
            tsbWriteWater = new ToolStripButton();
            panel2 = new Panel();
            gbIdentity = new GroupBox();
            ucidNumbers1 = new ucIDNumbers();
            toolStrip2 = new ToolStrip();
            tsbReadIDs = new ToolStripButton();
            tsbWriteID = new ToolStripButton();
            gbSelected = new GroupBox();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenu.SuspendLayout();
            gbIllumination.SuspendLayout();
            toolStrip3.SuspendLayout();
            gbWatering.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            gbIdentity.SuspendLayout();
            toolStrip2.SuspendLayout();
            gbSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // mainTree
            // 
            mainTree.AutoHeaderHeight = true;
            mainTree.BackColor = SystemColors.Window;
            mainTree.Columns.Add(tcName);
            mainTree.Columns.Add(tcControl);
            mainTree.Columns.Add(tcStatus);
            mainTree.ContextMenuStrip = contextMenu;
            mainTree.Dock = DockStyle.Fill;
            mainTree.Location = new Point(0, 0);
            mainTree.Name = "mainTree";
            mainTree.RowHeight = 20;
            mainTree.Size = new Size(613, 368);
            mainTree.TabIndex = 0;
            mainTree.Text = "MainTreeView";
            mainTree.UseColumns = true;
            mainTree.NodeMouseClick += mainTree_NodeMouseClick;
            mainTree.SelectionChanged += mainTree_SelectionChanged;
            // 
            // tcName
            // 
            tcName.TextAlign = HorizontalAlignment.Center;
            tcName.Width = 150;
            // 
            // tcControl
            // 
            tcControl.TextAlign = HorizontalAlignment.Center;
            tcControl.Width = 40;
            // 
            // tcStatus
            // 
            tcStatus.Width = 120;
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
            // labSelectedDevice
            // 
            labSelectedDevice.Dock = DockStyle.Fill;
            labSelectedDevice.Location = new Point(3, 19);
            labSelectedDevice.Name = "labSelectedDevice";
            labSelectedDevice.Size = new Size(446, 25);
            labSelectedDevice.TabIndex = 5;
            labSelectedDevice.Text = "label1";
            labSelectedDevice.TextAlign = ContentAlignment.MiddleCenter;
            labSelectedDevice.DoubleClick += labSelectedDevice_DoubleClick;
            // 
            // gbIllumination
            // 
            gbIllumination.Controls.Add(ucRecipe1);
            gbIllumination.Controls.Add(toolStrip3);
            gbIllumination.Dock = DockStyle.Top;
            gbIllumination.Location = new Point(0, 255);
            gbIllumination.Name = "gbIllumination";
            gbIllumination.Size = new Size(452, 382);
            gbIllumination.TabIndex = 3;
            gbIllumination.TabStop = false;
            gbIllumination.Text = "Illumination";
            // 
            // ucRecipe1
            // 
            ucRecipe1.Dock = DockStyle.Fill;
            ucRecipe1.Location = new Point(3, 44);
            ucRecipe1.Name = "ucRecipe1";
            ucRecipe1.Size = new Size(446, 335);
            ucRecipe1.TabIndex = 3;
            // 
            // toolStrip3
            // 
            toolStrip3.Items.AddRange(new ToolStripItem[] { tsbReadIllum, tsbWriteIllum });
            toolStrip3.Location = new Point(3, 19);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(446, 25);
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
            gbWatering.Size = new Size(452, 208);
            gbWatering.TabIndex = 4;
            gbWatering.TabStop = false;
            gbWatering.Text = "Watering";
            // 
            // ucWatering1
            // 
            ucWatering1.Dock = DockStyle.Top;
            ucWatering1.Location = new Point(3, 44);
            ucWatering1.Name = "ucWatering1";
            ucWatering1.Size = new Size(446, 153);
            ucWatering1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbReadWater, tsbWriteWater });
            toolStrip1.Location = new Point(3, 19);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(446, 25);
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
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(gbIdentity);
            panel2.Controls.Add(gbIllumination);
            panel2.Controls.Add(gbWatering);
            panel2.Controls.Add(gbSelected);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 552);
            panel2.TabIndex = 6;
            // 
            // gbIdentity
            // 
            gbIdentity.Controls.Add(ucidNumbers1);
            gbIdentity.Controls.Add(toolStrip2);
            gbIdentity.Dock = DockStyle.Top;
            gbIdentity.Location = new Point(0, 637);
            gbIdentity.Name = "gbIdentity";
            gbIdentity.Size = new Size(452, 622);
            gbIdentity.TabIndex = 6;
            gbIdentity.TabStop = false;
            gbIdentity.Text = "Devices";
            // 
            // ucidNumbers1
            // 
            ucidNumbers1.Dock = DockStyle.Fill;
            ucidNumbers1.Location = new Point(3, 44);
            ucidNumbers1.Name = "ucidNumbers1";
            ucidNumbers1.Size = new Size(446, 575);
            ucidNumbers1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { tsbReadIDs, tsbWriteID });
            toolStrip2.Location = new Point(3, 19);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(446, 25);
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
            gbSelected.Size = new Size(452, 47);
            gbSelected.TabIndex = 5;
            gbSelected.TabStop = false;
            gbSelected.Text = "Information";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(613, 180);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 552);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1086, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1086, 552);
            splitContainer1.SplitterDistance = 613;
            splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(mainTree);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(richTextBox1);
            splitContainer2.Size = new Size(613, 552);
            splitContainer2.SplitterDistance = 368;
            splitContainer2.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 574);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Name = "MainForm";
            Text = "Simargl";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load_1;
            contextMenu.ResumeLayout(false);
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeViewAdv mainTree;
        private TreeColumn tcName;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem tsmiReadIllum;
        private Label labSelectedDevice;
        private ToolStripMenuItem tsmiWriteIllum;
        private GroupBox gbIllumination;
        private ToolStripMenuItem tsmiReadWater;
        private GroupBox gbWatering;
        private ucWatering ucWatering1;
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
        private RichTextBox richTextBox1;
        private ucRecipe ucRecipe1;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TreeColumn tcStatus;
        private System.Windows.Forms.Timer timer1;
        private TreeColumn tcControl;
    }
}
