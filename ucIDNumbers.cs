using Simargl.HorticultureModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simargl
{
    public partial class ucIDNumbers : UserControl
    {
        private SubDevIDs subDevIDs = new SubDevIDs();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SubDevIDs SubDevIDs
        {
            get => subDevIDs;
            set
            {
                if (subDevIDs.Equals(value)) return;
                subDevIDs.Loaded -= (s, e) => ToDataGridViewWithInvoke();
                subDevIDs = value;
                subDevIDs.Loaded += (s, e) => ToDataGridViewWithInvoke();
                ToDataGridViewWithInvoke();
            }
        }
        public ucIDNumbers()
        {
            InitializeComponent();
            dgvSensors.Rows.Add(4);
            dgvLights.Rows.Add(16);

            dgvSensors.Rows[0].Cells[0].Value = "1";
            dgvSensors.Rows[1].Cells[0].Value = "2";
            dgvSensors.Rows[2].Cells[0].Value = "3";
            dgvSensors.Rows[3].Cells[0].Value = "4";

            dgvSensors.Rows[0].Cells[3].Value = "5";
            dgvSensors.Rows[1].Cells[3].Value = "6";
            dgvSensors.Rows[2].Cells[3].Value = "7";
            dgvSensors.Rows[3].Cells[3].Value = "8";

            dgvSensors.Rows[0].Cells[6].Value = "9";
            dgvSensors.Rows[1].Cells[6].Value = "10";
            dgvSensors.Rows[2].Cells[6].Value = "11";
            dgvSensors.Rows[3].Cells[6].Value = "12";

            dgvSensors.Rows[0].Cells[9].Value = "13";
            dgvSensors.Rows[1].Cells[9].Value = "14";
            dgvSensors.Rows[2].Cells[9].Value = "15";
            dgvSensors.Rows[3].Cells[9].Value = "16";

            for (int i = 0; i < 64; i++)
            {
                dgvLights.Rows[i % 16].Cells[i / 16 * 3].Value = i + 1;
            }

            subDevIDs.Loaded += (s, e) => ToDataGridViewWithInvoke();
        }
        private void ToDataGridViewWithInvoke()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ToDataGridView));
            }
            else
            {
                ToDataGridView();
            }
        }
        private void ToDataGridView()
        {
            for (int i = 0; i < 16; i++)
            {
                try
                {
                    dgvSensors.CellValueChanged -= dgvSensors_CellValueChanged;
                    dgvSensors.Rows[i % 4].Cells[(i / 4) * 3 + 2].Value = SubDevIDs.GetSensorIDString(i);
                    dgvSensors.Rows[i % 4].Cells[(i / 4) * 3 + 1].Value = SubDevIDs.IsSensorOn(i);
                    dgvSensors.CellValueChanged += dgvSensors_CellValueChanged;
                }
                catch
                {
                    dgvSensors.CellValueChanged -= dgvSensors_CellValueChanged;
                    dgvSensors.Rows[i % 4].Cells[(i / 4) * 3 + 2].Value = "0";
                    dgvSensors.CellValueChanged += dgvSensors_CellValueChanged;
                }
            }
            for (int i = 0; i < 64; i++)
            {
                try
                {
                    dgvLights.CellValueChanged -= dgvLights_CellValueChanged;
                    dgvLights.Rows[i % 16].Cells[i / 16 * 3 + 2].Value = SubDevIDs.GetLightID(i);
                    dgvLights.Rows[i % 16].Cells[i / 16 * 3 + 1].Value = SubDevIDs.IsLightOn(i);
                    dgvLights.CellValueChanged += dgvLights_CellValueChanged;
                }
                catch
                {
                    dgvLights.CellValueChanged -= dgvLights_CellValueChanged;
                    dgvLights.Rows[i % 16].Cells[i / 16 * 3 + 2].Value = "0";
                    dgvLights.CellValueChanged += dgvLights_CellValueChanged;
                }
            }
        }
        private void dgvSensors_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > 3) return;
            if (e.ColumnIndex == 2 || e.ColumnIndex == 5 || e.ColumnIndex == 8 || e.ColumnIndex == 11)
            {
                var index = e.RowIndex * 4 + e.ColumnIndex / 3;
                if (dgvSensors.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is string value)
                {
                    SubDevIDs.SetSensorID(index, Convert.ToUInt32(value.Replace("-", "").Replace(" ", ""), 16));
                    dgvSensors.CellValueChanged -= dgvSensors_CellValueChanged;
                    dgvSensors.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = SubDevIDs.GetSensorIDString(index);
                    dgvSensors.CellValueChanged += dgvSensors_CellValueChanged;
                }
                else
                {
                    SubDevIDs.SetSensorID(index, 0);
                }
            }
            else if (e.ColumnIndex == 1 || e.ColumnIndex == 4 || e.ColumnIndex == 7 || e.ColumnIndex == 10)
            {
                var index = e.RowIndex * 4 + e.ColumnIndex / 3;
                if (dgvSensors.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is bool value)
                {
                    SubDevIDs.SensorOn(index, value);
                }
            }
        }

        private void dgvLights_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > 15) return;
            if (e.ColumnIndex == 2 || e.ColumnIndex == 5 || e.ColumnIndex == 8 || e.ColumnIndex == 11)
            {
                var index = e.RowIndex * 4 + e.ColumnIndex / 3;
                if (dgvLights.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is string value)
                {
                    SubDevIDs.SetLightID(index, Convert.ToUInt32(value.Replace("-", "").Replace(" ", ""), 16));
                    dgvLights.CellValueChanged -= dgvLights_CellValueChanged;
                    dgvLights.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = SubDevIDs.GetLightID(index);
                    dgvLights.CellValueChanged += dgvLights_CellValueChanged;
                }
                else
                {
                    SubDevIDs.SetLightID(index, 0);
                }
            }
            else if (e.ColumnIndex == 1 || e.ColumnIndex == 4 || e.ColumnIndex == 7 || e.ColumnIndex == 10)
            {
                var index = e.RowIndex * 4 + e.ColumnIndex / 3;
                if (dgvLights.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is bool value)
                {
                    SubDevIDs.LightOn(index, value);
                }
            }
        }
        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (sender is DataGridView dgv && dgv.CurrentCell != null && (dgv.CurrentCell.ColumnIndex == 2 || dgv.CurrentCell.ColumnIndex == 5 || dgv.CurrentCell.ColumnIndex == 8 || dgv.CurrentCell.ColumnIndex == 11))
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress -= TextBox_KeyPress;
                    tb.KeyPress += TextBox_KeyPress;

                    tb.TextChanged -= TextBox_TextChanged;
                    tb.TextChanged += TextBox_TextChanged;
                }
            }
        }
        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox) return;
            // Разрешить только 0-9, A-F, a-f и Backspace
            if (!Uri.IsHexDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            if (textBox.Text.Replace("-", "").Length >= 8 && textBox.SelectionLength == 0)
            {
                e.Handled = true;
                return;
            }
            if (textBox.SelectionLength > 0)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Remove(selectionStart, textBox.SelectionLength).Insert(selectionStart, e.KeyChar.ToString());
                textBox.SelectionStart = selectionStart + 1;
                e.Handled = true;
            }
        }
        private void TextBox_TextChanged(object? sender, EventArgs e)
        {
            TextBox? txtBox = sender as TextBox;

            if (txtBox != null)
            {
                // Удаление всех дефисов и пробелов из текста
                string hexString = txtBox.Text.Replace("-", "").Replace(" ", "");

                // Если строка не пустая
                if (hexString.Length > 0)
                {
                    txtBox.TextChanged -= TextBox_TextChanged;
                    txtBox.Text = string.Join("-", Enumerable.Range(0, hexString.Length / 2)
                                                              .Select(i => hexString.Substring(i * 2, 2))
                                                              .Concat(new[] { hexString.Substring(hexString.Length / 2 * 2) })
                                                              .Where(s => s.Length > 0));
                    txtBox.SelectionStart = txtBox.Text.Length;
                    txtBox.TextChanged += TextBox_TextChanged;
                }
            }
        }
        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 5 || e.ColumnIndex == 8 || e.ColumnIndex == 11)
            {
                if (e.Value is uint value)
                {
                    e.Value = string.Join("-", BitConverter.GetBytes(value).Reverse().Select(b => b.ToString("X2")));
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
