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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
            progressBar1.Maximum = 10000000;
            progressBar1.Step = 1;
            int j = 0;
            while (j < 10000000)
            {
                j++;
                Caluculate(j);
                progressBar1.PerformStep();
            }
            string porcentagem = "completado";
            Loading.Text = porcentagem.ToString();
        }
    }
}
