using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "Agora você conseguiu definir o que será a chave do seu hábito.";
            string titulo = "Parabéns";

            MessageBoxButtons botao = MessageBoxButtons.OK;

            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);

            if (resultado == DialogResult.OK)
            {
                var tela = new Form2();
                tela.ShowDialog();
                Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Tente definir novamente o que será a chave do seu hábito.";
            string titulo = "Tente Novamente";

            MessageBoxButtons botao = MessageBoxButtons.OK;

            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);
        }
    }
}
