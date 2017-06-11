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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "Agora você conseguiu definir a recompensa caso consiga repetir a atividade.";
            string titulo = "Parabéns";

            MessageBoxButtons botao = MessageBoxButtons.OK;
            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);


            if (resultado == DialogResult.OK)
            {
                var tela = new Form4();
                tela.ShowDialog();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Tente definir uma recompensa caso consiga repetir a atividade.";
            string titulo = "Tente Novamente";

            MessageBoxButtons botao = MessageBoxButtons.OK;
            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
