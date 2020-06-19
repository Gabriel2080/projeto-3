using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_3_Principal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(numericUpDown1.Text);
            int green = Convert.ToInt32(numericUpDown2.Text);
            int blue = Convert.ToInt32(numericUpDown3.Text);

            panel1.BackColor = Color.FromArgb(red, green, blue);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
