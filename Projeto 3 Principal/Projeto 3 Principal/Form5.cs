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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
                label1.ImageIndex = 0;
            if (listBox1.SelectedIndex == 1)
                label1.ImageIndex = 1;
            if (listBox1.SelectedIndex == 2)
                label1.ImageIndex = 2;
            if (listBox1.SelectedIndex == 3)
                label1.ImageIndex = 3;
        }
    }
}
