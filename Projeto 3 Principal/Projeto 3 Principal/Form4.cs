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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                pictureBox1.Visible = false;
            if (checkBox1.Checked == true)
                pictureBox1.Visible = true;
        }
    }
}
