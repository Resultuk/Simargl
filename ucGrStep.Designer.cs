namespace Simargl
{
    partial class ucGrStep
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
            tableLayoutPanel1 = new TableLayoutPanel();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(numericUpDown1, 5, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 4, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown3, 3, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown4, 2, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(412, 31);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Location = new Point(362, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown2.Location = new Point(311, 4);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(45, 23);
            numericUpDown2.TabIndex = 0;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown3.Location = new Point(260, 4);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(45, 23);
            numericUpDown3.TabIndex = 0;
            numericUpDown3.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown4.Location = new Point(209, 4);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(45, 23);
            numericUpDown4.TabIndex = 0;
            numericUpDown4.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown5.Location = new Point(106, 4);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(97, 23);
            numericUpDown5.TabIndex = 0;
            // 
            // ucGrStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucGrStep";
            Size = new Size(412, 31);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
    }
}
