using Simargl.Device;
using Simargl.HorticultureModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simargl
{
    public partial class ucRecipe : UserControl
    {
        private AgroRecipe recipe = new AgroRecipe();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AgroRecipe Recipe
        {
            get => recipe;
            set
            {
                if (recipe.Equals(value)) return;
                recipe.Loaded -= (s, e) => ToControlIfNeedAction();
                recipe = value;
                recipe.Loaded += (s, e) => ToControlIfNeedAction();
                ToControlIfNeedAction();
            }
        }
        public ucRecipe()
        {
            InitializeComponent();
            recipe.Loaded += (s, e) => ToControlIfNeedAction();

            // Регистрация событий для tBSwtc_ch
            tBSwtc_ch.Enter += tBSwtc_ch_Enter;
            tBSwtc_ch.Leave += tBSwtc_ch_Leave;

            dataGridView1.Rows.Add(12);
            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = $"Step - {i + 1}";
            }
            comboBox1.SelectedIndex = 0;
        }
        private void ToControlIfNeedAction()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ToControl()));
            }
            else
            {
                ToControl();
            }
        }
        private void ToControl()
        {
            nudLoops.ValueChanged -= nudLoops_ValueChanged;
            nudLoops.Value = Recipe.Phases[comboBox1.SelectedIndex].Loops;
            nudLoops.ValueChanged += nudLoops_ValueChanged;

            dateTimePicker1.ValueChanged -= dateTimePicker1_ValueChanged;
            dateTimePicker1.Value = DateTimeOffset.FromUnixTimeSeconds(Recipe.StartTime).DateTime;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;

            tBSwtc_ch.TextChanged -= tBSwtc_ch_TextChanged;
            tBSwtc_ch.Text = Utils.GetStringForTime(Recipe.SwitchToAuto);
            tBSwtc_ch.TextChanged += tBSwtc_ch_TextChanged;

            cbMode.SelectedIndexChanged -= cbMode_SelectedIndexChanged;
            cbMode.SelectedIndex = Recipe.Mode;
            cbMode.SelectedIndexChanged += cbMode_SelectedIndexChanged;

            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Recipe.Phases[comboBox1.SelectedIndex].Steps[i].Period;
                dataGridView1.Rows[i].Cells[1].Value = Recipe.Phases[comboBox1.SelectedIndex].Steps[i].CH1;
                dataGridView1.Rows[i].Cells[2].Value = Recipe.Phases[comboBox1.SelectedIndex].Steps[i].CH2;
                dataGridView1.Rows[i].Cells[3].Value = Recipe.Phases[comboBox1.SelectedIndex].Steps[i].CH3;
                dataGridView1.Rows[i].Cells[4].Value = Recipe.Phases[comboBox1.SelectedIndex].Steps[i].CH4;
            }
        }
        private void nudLoops_ValueChanged(object? sender, EventArgs e)
        {
            Recipe.Phases[comboBox1.SelectedIndex].Loops = (ushort)nudLoops.Value;
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ToControlIfNeedAction();
        }

        private void dataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var index = comboBox1.SelectedIndex;
            if (index < 0) return;
            var step = Recipe.Phases[index].Steps[e.RowIndex];
            var cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

            if (cellValue == null) return;

            if (e.ColumnIndex == 0)
            {
                if (ushort.TryParse(cellValue, out ushort res))
                {
                    step.Period = Convert.ToUInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                }
                else
                {
                    dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value = step.Period;
                    dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                if (byte.TryParse(cellValue, out byte res))
                {
                    step.CH1 = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                }
                else
                {
                    dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value = step.CH1;
                    dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                }
            }
            else if (e.ColumnIndex == 2)
            {
                if (byte.TryParse(cellValue, out byte res))
                {
                    step.CH2 = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                }
                else
                {
                    dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = step.CH2;
                    dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                }
            }
            else if (e.ColumnIndex == 3)
            {
                if (byte.TryParse(cellValue, out byte res))
                {
                    step.CH3 = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                }
                else
                {
                    dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = step.CH3;
                    dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                }
            }
            else if (e.ColumnIndex == 4)
            {
                if (byte.TryParse(cellValue, out byte res))
                {
                    step.CH4 = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                }
                else
                {
                    dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = step.CH4;
                    dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object? sender, EventArgs e)
        {
            DateTimeOffset dateTimeOffset = DateTime.SpecifyKind(dateTimePicker1.Value, DateTimeKind.Utc);
            Recipe.StartTime = (uint)dateTimeOffset.ToUnixTimeSeconds();
        }

        private void tBSwtc_ch_TextChanged(object? sender, EventArgs e)
        {
            if (sender is TextBox textbox)
            {
                if (ushort.TryParse(textbox.Text, out ushort res))
                {
                    Recipe.SwitchToAuto = Convert.ToUInt16(textbox.Text);
                }
                else
                {
                    textbox.TextChanged -= tBSwtc_ch_TextChanged;
                    textbox.Text = Recipe.SwitchToAuto.ToString();
                    textbox.TextChanged += tBSwtc_ch_TextChanged;
                }
            }
        }

        private void cbMode_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                Recipe.Mode = (ushort)comboBox.SelectedIndex;
            }
        }

        private void tBSwtc_ch_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textbox)
            {
                // Убираем форматирование и показываем число в секундах
                textbox.Text = Recipe.SwitchToAuto.ToString();
            }
        }

        private void tBSwtc_ch_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textbox)
            {
                // Применяем форматирование HH:mm:ss
                textbox.TextChanged -= tBSwtc_ch_TextChanged;
                textbox.Text = Utils.GetStringForTime(Recipe.SwitchToAuto);
                textbox.TextChanged += tBSwtc_ch_TextChanged;
            }
        }
    }
}
