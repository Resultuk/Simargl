namespace GroworDesktop
{
    partial class FormForRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForRecipe));
            tvaRecipe = new Aga.Controls.Tree.TreeViewAdv();
            tcRecipeName = new Aga.Controls.Tree.TreeColumn();
            tcRecipeDuration = new Aga.Controls.Tree.TreeColumn();
            tcRecipeInformation = new Aga.Controls.Tree.TreeColumn();
            conMenu = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            tsmiAddPeriod = new ToolStripMenuItem();
            tsmiLighting = new ToolStripMenuItem();
            tsmiAddControling = new ToolStripMenuItem();
            bRDBFRToolStripMenuItem = new ToolStripMenuItem();
            tsmiAddGroworLight = new ToolStripMenuItem();
            tsmiAddLighting = new ToolStripMenuItem();
            tmsiAddParameter = new ToolStripMenuItem();
            tsmiCalcPeriods = new ToolStripMenuItem();
            tsmiCopy = new ToolStripMenuItem();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            tsbAddItem = new ToolStripButton();
            tsbDelItem = new ToolStripButton();
            tsbCopyItem = new ToolStripButton();
            conMenu.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tvaRecipe
            // 
            tvaRecipe.BackColor = SystemColors.Window;
            tvaRecipe.Columns.Add(tcRecipeName);
            tvaRecipe.Columns.Add(tcRecipeDuration);
            tvaRecipe.Columns.Add(tcRecipeInformation);
            tvaRecipe.ContextMenuStrip = conMenu;
            tvaRecipe.Dock = DockStyle.Top;
            tvaRecipe.Font = new Font("Microsoft Sans Serif", 8.25F);
            tvaRecipe.Location = new Point(0, 25);
            tvaRecipe.Margin = new Padding(3, 4, 3, 4);
            tvaRecipe.Name = "tvaRecipe";
            tvaRecipe.Size = new Size(543, 533);
            tvaRecipe.TabIndex = 0;
            tvaRecipe.UseColumns = true;
            // 
            // tcRecipeName
            // 
            tcRecipeName.TextAlign = HorizontalAlignment.Center;
            tcRecipeName.Width = 150;
            // 
            // tcRecipeDuration
            // 
            tcRecipeDuration.TextAlign = HorizontalAlignment.Center;
            tcRecipeDuration.Width = 65;
            // 
            // tcRecipeInformation
            // 
            tcRecipeInformation.TextAlign = HorizontalAlignment.Center;
            tcRecipeInformation.Width = 300;
            // 
            // conMenu
            // 
            conMenu.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, tsmiAddGroworLight, tsmiAddLighting, tmsiAddParameter, tsmiCalcPeriods, tsmiCopy });
            conMenu.Name = "contextMenuStrip1";
            conMenu.Size = new Size(204, 136);
            conMenu.Opening += conMenu_Opening;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiAddPeriod, tsmiLighting, tsmiAddControling, bRDBFRToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(203, 22);
            addToolStripMenuItem.Text = "Add";
            // 
            // tsmiAddPeriod
            // 
            tsmiAddPeriod.Name = "tsmiAddPeriod";
            tsmiAddPeriod.Size = new Size(137, 22);
            tsmiAddPeriod.Text = "Period";
            // 
            // tsmiLighting
            // 
            tsmiLighting.Name = "tsmiLighting";
            tsmiLighting.Size = new Size(137, 22);
            tsmiLighting.Text = "Lighting";
            // 
            // tsmiAddControling
            // 
            tsmiAddControling.Name = "tsmiAddControling";
            tsmiAddControling.Size = new Size(137, 22);
            tsmiAddControling.Text = "Controling";
            // 
            // bRDBFRToolStripMenuItem
            // 
            bRDBFRToolStripMenuItem.Name = "bRDBFRToolStripMenuItem";
            bRDBFRToolStripMenuItem.Size = new Size(137, 22);
            bRDBFRToolStripMenuItem.Text = "B, R, DB, FR ";
            // 
            // tsmiAddGroworLight
            // 
            tsmiAddGroworLight.Name = "tsmiAddGroworLight";
            tsmiAddGroworLight.Size = new Size(203, 22);
            tsmiAddGroworLight.Text = "Add (B, R, DB, FR)";
            tsmiAddGroworLight.Click += tsmiAddGroworLight_Click;
            // 
            // tsmiAddLighting
            // 
            tsmiAddLighting.Name = "tsmiAddLighting";
            tsmiAddLighting.Size = new Size(203, 22);
            tsmiAddLighting.Text = "Adding a lighting period";
            tsmiAddLighting.Click += tsmiAddLighting_Click;
            // 
            // tmsiAddParameter
            // 
            tmsiAddParameter.Name = "tmsiAddParameter";
            tmsiAddParameter.Size = new Size(203, 22);
            tmsiAddParameter.Text = "Adding a parameter";
            tmsiAddParameter.Click += tmsiAddParameter_Click;
            // 
            // tsmiCalcPeriods
            // 
            tsmiCalcPeriods.Name = "tsmiCalcPeriods";
            tsmiCalcPeriods.Size = new Size(203, 22);
            tsmiCalcPeriods.Text = "Calculate periods";
            tsmiCalcPeriods.Click += tsmiCalcPeriods_Click;
            // 
            // tsmiCopy
            // 
            tsmiCopy.Name = "tsmiCopy";
            tsmiCopy.Size = new Size(203, 22);
            tsmiCopy.Text = "Copy";
            tsmiCopy.Click += tsmiCopy_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tvaRecipe);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 558);
            panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAddItem, tsbDelItem, tsbCopyItem });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(543, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddItem
            // 
            tsbAddItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAddItem.Image = (Image)resources.GetObject("tsbAddItem.Image");
            tsbAddItem.ImageTransparentColor = Color.Magenta;
            tsbAddItem.Name = "tsbAddItem";
            tsbAddItem.Size = new Size(23, 22);
            tsbAddItem.Text = "toolStripButton1";
            tsbAddItem.ToolTipText = "Adding an element";
            tsbAddItem.Click += tsbAddPhase_Click;
            // 
            // tsbDelItem
            // 
            tsbDelItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDelItem.Image = (Image)resources.GetObject("tsbDelItem.Image");
            tsbDelItem.ImageTransparentColor = Color.Magenta;
            tsbDelItem.Name = "tsbDelItem";
            tsbDelItem.Size = new Size(23, 22);
            tsbDelItem.Text = "toolStripButton1";
            tsbDelItem.ToolTipText = "Remove an element";
            tsbDelItem.Click += tsbDelPhase_Click;
            // 
            // tsbCopyItem
            // 
            tsbCopyItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCopyItem.Image = Simargl.Res.copy;
            tsbCopyItem.ImageTransparentColor = Color.Magenta;
            tsbCopyItem.Name = "tsbCopyItem";
            tsbCopyItem.Size = new Size(23, 22);
            tsbCopyItem.Text = "toolStripButton1";
            tsbCopyItem.Click += tsbCopyItem_Click;
            // 
            // FormForRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 558);
            Controls.Add(panel1);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormForRecipe";
            Text = "FormForRecipe";
            Load += FormForRecipe_Load;
            conMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Aga.Controls.Tree.TreeViewAdv tvaRecipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddItem;
        private System.Windows.Forms.ToolStripButton tsbDelItem;
        private Aga.Controls.Tree.TreeColumn tcRecipeName;
        private Aga.Controls.Tree.TreeColumn tcRecipeDuration;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddLighting;
        private System.Windows.Forms.ToolStripMenuItem tmsiAddParameter;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalcPeriods;
        private Aga.Controls.Tree.TreeColumn tcRecipeInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddGroworLight;
        private System.Windows.Forms.ToolStripButton tsbCopyItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddPeriod;
        private System.Windows.Forms.ToolStripMenuItem tsmiLighting;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddControling;
        private System.Windows.Forms.ToolStripMenuItem bRDBFRToolStripMenuItem;
    }
}