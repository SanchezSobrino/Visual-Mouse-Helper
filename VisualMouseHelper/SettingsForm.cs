using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualMouseHelper
{
    public partial class SettingsForm : Form
    {
        private SolidBrush brush1;
        private SolidBrush brush2;

        public SettingsForm(SolidBrush brush1, SolidBrush brush2)
        {
            InitializeComponent();

            this.brush1 = brush1;
            this.brush2 = brush2;

            this.color1.BackColor = Properties.Settings.Default.Color1;
            this.color2.BackColor = Properties.Settings.Default.Color2;
            this.freq.Value = Convert.ToDecimal(Properties.Settings.Default.Frequency);
            this.size.Value = Convert.ToDecimal(Properties.Settings.Default.Size);
            this.posX.Value = Convert.ToDecimal(Properties.Settings.Default.PosX);
            this.posY.Value = Convert.ToDecimal(Properties.Settings.Default.PosY);
            this.offsetX.Value = Convert.ToDecimal(Properties.Settings.Default.OffsetX);
            this.offsetY.Value = Convert.ToDecimal(Properties.Settings.Default.OffsetY);
        }

        private void color1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.Color1 = colorDialog.Color;
                this.color1.BackColor = Properties.Settings.Default.Color1;
                this.brush1.Color = Properties.Settings.Default.Color1;
                Properties.Settings.Default.Save();
            }
        }

        private void color2_click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.Color2 = colorDialog.Color;
                this.color2.BackColor = Properties.Settings.Default.Color2;
                this.brush2.Color = Properties.Settings.Default.Color2;
                Properties.Settings.Default.Save();
            }
        }

        private void freq_Changed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Frequency = Convert.ToInt32(this.freq.Value);
            Properties.Settings.Default.Save();
        }

        private void size_Changed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Size = Convert.ToInt32(this.size.Value);
            Properties.Settings.Default.Save();
        }

        private void posX_Changed(object sender, EventArgs e)
        {
            Properties.Settings.Default.PosX = Convert.ToInt32(this.posX.Value);
            Properties.Settings.Default.Save();
        }

        private void posY_Changed(object sender, EventArgs e)
        {
            Properties.Settings.Default.PosY = Convert.ToInt32(this.posY.Value);
            Properties.Settings.Default.Save();
        }

        private void offsetX_Changed(object sender, EventArgs e)
        {
            Properties.Settings.Default.OffsetX = Convert.ToInt32(this.offsetX.Value);
            Properties.Settings.Default.Save();
        }

        private void offsetY_Changed(object sender, EventArgs e)
        {
            Properties.Settings.Default.OffsetY = Convert.ToInt32(this.offsetY.Value);
            Properties.Settings.Default.Save();
        }
    }
}
