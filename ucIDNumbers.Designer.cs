namespace Simargl
{
    partial class ucIDNumbers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvSensors = new DataGridView();
            clmNumber1 = new DataGridViewTextBoxColumn();
            clmOn1 = new DataGridViewCheckBoxColumn();
            clmID1 = new DataGridViewTextBoxColumn();
            clmNumber2 = new DataGridViewTextBoxColumn();
            clmOn2 = new DataGridViewCheckBoxColumn();
            clmID2 = new DataGridViewTextBoxColumn();
            clmNumber3 = new DataGridViewTextBoxColumn();
            clmOn3 = new DataGridViewCheckBoxColumn();
            clmID3 = new DataGridViewTextBoxColumn();
            clmNumber4 = new DataGridViewTextBoxColumn();
            clmOn4 = new DataGridViewCheckBoxColumn();
            clmID4 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dgvLights = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn3 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn4 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSensors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLights).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(594, 20);
            label1.TabIndex = 0;
            label1.Text = "Serial numbers of the sensors";
            // 
            // dgvSensors
            // 
            dgvSensors.AllowUserToAddRows = false;
            dgvSensors.AllowUserToDeleteRows = false;
            dgvSensors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSensors.ColumnHeadersVisible = false;
            dgvSensors.Columns.AddRange(new DataGridViewColumn[] { clmNumber1, clmOn1, clmID1, clmNumber2, clmOn2, clmID2, clmNumber3, clmOn3, clmID3, clmNumber4, clmOn4, clmID4 });
            dgvSensors.Dock = DockStyle.Top;
            dgvSensors.Location = new Point(0, 20);
            dgvSensors.Name = "dgvSensors";
            dgvSensors.RowHeadersVisible = false;
            dgvSensors.Size = new Size(594, 125);
            dgvSensors.TabIndex = 1;
            dgvSensors.CellValueChanged += dgvSensors_CellValueChanged;
            // 
            // clmNumber1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clmNumber1.DefaultCellStyle = dataGridViewCellStyle1;
            clmNumber1.HeaderText = "";
            clmNumber1.Name = "clmNumber1";
            clmNumber1.ReadOnly = true;
            clmNumber1.Width = 20;
            // 
            // clmOn1
            // 
            clmOn1.HeaderText = "";
            clmOn1.Name = "clmOn1";
            clmOn1.Width = 20;
            // 
            // clmID1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clmID1.DefaultCellStyle = dataGridViewCellStyle2;
            clmID1.HeaderText = "ID";
            clmID1.Name = "clmID1";
            // 
            // clmNumber2
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clmNumber2.DefaultCellStyle = dataGridViewCellStyle3;
            clmNumber2.HeaderText = "";
            clmNumber2.Name = "clmNumber2";
            clmNumber2.ReadOnly = true;
            clmNumber2.Width = 20;
            // 
            // clmOn2
            // 
            clmOn2.HeaderText = "";
            clmOn2.Name = "clmOn2";
            clmOn2.Width = 20;
            // 
            // clmID2
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clmID2.DefaultCellStyle = dataGridViewCellStyle4;
            clmID2.HeaderText = "ID";
            clmID2.Name = "clmID2";
            // 
            // clmNumber3
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clmNumber3.DefaultCellStyle = dataGridViewCellStyle5;
            clmNumber3.HeaderText = "";
            clmNumber3.Name = "clmNumber3";
            clmNumber3.ReadOnly = true;
            clmNumber3.Width = 20;
            // 
            // clmOn3
            // 
            clmOn3.HeaderText = "";
            clmOn3.Name = "clmOn3";
            clmOn3.Width = 20;
            // 
            // clmID3
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clmID3.DefaultCellStyle = dataGridViewCellStyle6;
            clmID3.HeaderText = "ID";
            clmID3.Name = "clmID3";
            // 
            // clmNumber4
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clmNumber4.DefaultCellStyle = dataGridViewCellStyle7;
            clmNumber4.HeaderText = "";
            clmNumber4.Name = "clmNumber4";
            clmNumber4.ReadOnly = true;
            clmNumber4.Width = 20;
            // 
            // clmOn4
            // 
            clmOn4.HeaderText = "";
            clmOn4.Name = "clmOn4";
            clmOn4.Width = 20;
            // 
            // clmID4
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clmID4.DefaultCellStyle = dataGridViewCellStyle8;
            clmID4.HeaderText = "ID";
            clmID4.Name = "clmID4";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 145);
            label2.Name = "label2";
            label2.Size = new Size(594, 20);
            label2.TabIndex = 2;
            label2.Text = "Serial numbers of Light";
            // 
            // dgvLights
            // 
            dgvLights.AllowUserToAddRows = false;
            dgvLights.AllowUserToDeleteRows = false;
            dgvLights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLights.ColumnHeadersVisible = false;
            dgvLights.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewCheckBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewCheckBoxColumn3, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewCheckBoxColumn4, dataGridViewTextBoxColumn8 });
            dgvLights.Dock = DockStyle.Fill;
            dgvLights.Location = new Point(0, 165);
            dgvLights.Name = "dgvLights";
            dgvLights.RowHeadersVisible = false;
            dgvLights.Size = new Size(594, 393);
            dgvLights.TabIndex = 3;
            dgvLights.CellFormatting += dgvLights_CellFormatting;
            dgvLights.CellValueChanged += dgvLights_CellValueChanged;
            dgvLights.EditingControlShowing += dgvLights_EditingControlShowing;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewTextBoxColumn1.HeaderText = "";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 20;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.HeaderText = "";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTextBoxColumn2.HeaderText = "ID";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn3.HeaderText = "";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 20;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            dataGridViewCheckBoxColumn2.HeaderText = "";
            dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            dataGridViewCheckBoxColumn2.Width = 20;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTextBoxColumn4.HeaderText = "ID";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTextBoxColumn5.HeaderText = "";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 20;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            dataGridViewCheckBoxColumn3.HeaderText = "";
            dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            dataGridViewCheckBoxColumn3.Width = 20;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTextBoxColumn6.HeaderText = "ID";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn7.HeaderText = "";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 20;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            dataGridViewCheckBoxColumn4.HeaderText = "";
            dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            dataGridViewCheckBoxColumn4.Width = 20;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn8.HeaderText = "ID";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // ucIDNumbers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvLights);
            Controls.Add(label2);
            Controls.Add(dgvSensors);
            Controls.Add(label1);
            Name = "ucIDNumbers";
            Size = new Size(594, 558);
            ((System.ComponentModel.ISupportInitialize)dgvSensors).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLights).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvSensors;
        private Label label2;
        private DataGridViewTextBoxColumn clmNumber1;
        private DataGridViewCheckBoxColumn clmOn1;
        private DataGridViewTextBoxColumn clmID1;
        private DataGridViewTextBoxColumn clmNumber2;
        private DataGridViewCheckBoxColumn clmOn2;
        private DataGridViewTextBoxColumn clmID2;
        private DataGridViewTextBoxColumn clmNumber3;
        private DataGridViewCheckBoxColumn clmOn3;
        private DataGridViewTextBoxColumn clmID3;
        private DataGridViewTextBoxColumn clmNumber4;
        private DataGridViewCheckBoxColumn clmOn4;
        private DataGridViewTextBoxColumn clmID4;
        private DataGridView dgvLights;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
