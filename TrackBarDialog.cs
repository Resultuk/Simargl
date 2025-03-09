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
    public partial class TrackBarDialog : Form
    {
        private TrackBar trackBar;
        private Button okButton;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedValue { get; private set; }
        public TrackBarDialog(Point cursorPosition)
        {
            InitializeComponent();
            this.Text = "Edit Value";
            this.Width = 300;
            this.Height = 150;
            this.FormBorderStyle = FormBorderStyle.None; // Убираем верхнее меню окна  

            // Устанавливаем позицию окна так, чтобы один край был у курсора  
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(cursorPosition.X, cursorPosition.Y);

            trackBar = new TrackBar
            {
                Minimum = 0,
                Maximum = 100,
                TickFrequency = 10,
                Dock = DockStyle.Top
            };

            okButton = new Button
            {
                Text = "OK",
                Dock = DockStyle.Bottom
            };
            okButton.Click += OkButton_Click;

            this.Controls.Add(trackBar);
            this.Controls.Add(okButton);

            this.Deactivate += TrackBarDialog_Deactivate;
            this.KeyDown += TrackBarDialog_KeyDown;

            // Ensure the form can receive key events
            this.KeyPreview = true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SelectedValue = trackBar.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TrackBarDialog_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrackBarDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
