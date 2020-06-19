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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 1)
            panel1.BackColor = Color.Transparent;

            if (trackBar1.Value == 0)
                panel1.BackColor = Color.Black;
        }
    }
}
