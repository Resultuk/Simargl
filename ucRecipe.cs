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
            DateTimeOffset dateTimeOffset = new DateTimeOffset(dateTimePicker1.Value);
            Recipe.StartTime = (uint)dateTimeOffset.ToUnixTimeSeconds();
        }
    }
}
