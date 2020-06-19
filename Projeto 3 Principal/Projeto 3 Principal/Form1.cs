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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Rgb = new Form2();
            Rgb.ShowDialog();
        }

        private void Site_Click(object sender, EventArgs e)
        {
            Form3 Site = new Form3();
            Site.ShowDialog();
        }

        private void Animacao_Click(object sender, EventArgs e)
        {
            Form4 Animacao = new Form4();
            Animacao.ShowDialog();
        }

        private void Imagens_Click(object sender, EventArgs e)
        {
            Form5 Imagens = new Form5();
            Imagens.ShowDialog();
        }

        private void Escolherimagem_Click(object sender, EventArgs e)
        {
            Form6 Escolherimagem = new Form6();
            Escolherimagem.ShowDialog();
        }

        private void Links_Click(object sender, EventArgs e)
        {
            Form7 Links = new Form7();
            Links.ShowDialog();
        }

        private void Algoescondido_Click(object sender, EventArgs e)
        {
            Form8 Algoescondido = new Form8();
            Algoescondido.ShowDialog();
        }

        private void Loading_Click(object sender, EventArgs e)
        {
            Form9 Loading = new Form9();
            Loading.ShowDialog();
        }

        private void Cronometro_Click(object sender, EventArgs e)
        {
            Form10 Cronometro = new Form10();
            Cronometro.ShowDialog();
        }

        private void Recomendacoes_Click(object sender, EventArgs e)
        {
            Form11 Recomendacoes = new Form11();
            Recomendacoes.ShowDialog();
        }
    }
}
