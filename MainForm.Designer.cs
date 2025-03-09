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
            contextMenu = new ContextMenuStrip(components);
            tsmiRead = new ToolStripMenuItem();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            tabPage9 = new TabPage();
            tabPage10 = new TabPage();
            tabPage11 = new TabPage();
            tabPage12 = new TabPage();
            tabPage13 = new TabPage();
            tabPage14 = new TabPage();
            tabPage15 = new TabPage();
            tabPage16 = new TabPage();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            splitter1 = new Splitter();
            label1 = new Label();
            contextMenu.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            panel2.SuspendLayout();
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
            mainTree.Size = new Size(372, 450);
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
            contextMenu.Items.AddRange(new ToolStripItem[] { tsmiRead });
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new Size(101, 26);
            // 
            // tsmiRead
            // 
            tsmiRead.Name = "tsmiRead";
            tsmiRead.Size = new Size(100, 22);
            tsmiRead.Text = "Read";
            tsmiRead.Click += tsmiRead_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(372, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 450);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Controls.Add(tabPage9);
            tabControl1.Controls.Add(tabPage10);
            tabControl1.Controls.Add(tabPage11);
            tabControl1.Controls.Add(tabPage12);
            tabControl1.Controls.Add(tabPage13);
            tabControl1.Controls.Add(tabPage14);
            tabControl1.Controls.Add(tabPage15);
            tabControl1.Controls.Add(tabPage16);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(24, 80);
            tabControl1.Location = new Point(0, 47);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(428, 403);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 1;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(84, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(340, 395);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phase-1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(84, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(340, 395);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Phase-2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(84, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(340, 395);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Phase-3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(84, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(340, 395);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Phase-4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(84, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(340, 395);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Phase-5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(84, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(340, 395);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Phase-6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(84, 4);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(340, 395);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Phase-7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(84, 4);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(340, 395);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Phase-8";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            tabPage9.Location = new Point(84, 4);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(340, 395);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "Phase-9";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            tabPage10.Location = new Point(84, 4);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new Size(340, 395);
            tabPage10.TabIndex = 9;
            tabPage10.Text = "Phase-10";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            tabPage11.Location = new Point(84, 4);
            tabPage11.Name = "tabPage11";
            tabPage11.Size = new Size(340, 395);
            tabPage11.TabIndex = 10;
            tabPage11.Text = "Phase-11";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            tabPage12.Location = new Point(84, 4);
            tabPage12.Name = "tabPage12";
            tabPage12.Size = new Size(340, 395);
            tabPage12.TabIndex = 11;
            tabPage12.Text = "Phase-12";
            tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            tabPage13.Location = new Point(84, 4);
            tabPage13.Name = "tabPage13";
            tabPage13.Size = new Size(340, 395);
            tabPage13.TabIndex = 12;
            tabPage13.Text = "Phase-13";
            tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            tabPage14.Location = new Point(84, 4);
            tabPage14.Name = "tabPage14";
            tabPage14.Size = new Size(340, 395);
            tabPage14.TabIndex = 13;
            tabPage14.Text = "Phase-14";
            tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            tabPage15.Location = new Point(84, 4);
            tabPage15.Name = "tabPage15";
            tabPage15.Size = new Size(340, 395);
            tabPage15.TabIndex = 14;
            tabPage15.Text = "Phase-15";
            tabPage15.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            tabPage16.Location = new Point(84, 4);
            tabPage16.Name = "tabPage16";
            tabPage16.Size = new Size(340, 395);
            tabPage16.TabIndex = 15;
            tabPage16.Text = "Phase-16";
            tabPage16.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 47);
            panel2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy.MM.dd HH:MM";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(104, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(372, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 450);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 18);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitter1);
            Controls.Add(panel1);
            Controls.Add(mainTree);
            Name = "MainForm";
            Text = "Simargl";
            contextMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeViewAdv mainTree;
        private TreeColumn tcName;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem tsmiRead;
        private Panel panel1;
        private Splitter splitter1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private TabPage tabPage13;
        private TabPage tabPage14;
        private TabPage tabPage15;
        private TabPage tabPage16;
        private Label label1;
    }
}
