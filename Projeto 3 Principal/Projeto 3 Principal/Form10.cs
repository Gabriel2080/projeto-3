using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_3_Principal
{
    public partial class Form10 : Form
    {
        private Stopwatch stopwatch;
        public Form10()
        {
            InitializeComponent();
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}
