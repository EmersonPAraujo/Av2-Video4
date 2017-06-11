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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "Agora você conseguiu definir atividade que estará ligado ao seu hábito.";
            string titulo = "Parabéns";

            MessageBoxButtons botao = MessageBoxButtons.OK;
            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);


            if (resultado == DialogResult.OK)
            {
                var tela = new Form3();
                tela.ShowDialog();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Tente novamente definir atividade que estará ligado ao seu hábito.";
            string titulo = "Tente Novamente";

            MessageBoxButtons botao = MessageBoxButtons.OK;
            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);
        }
    }
}
