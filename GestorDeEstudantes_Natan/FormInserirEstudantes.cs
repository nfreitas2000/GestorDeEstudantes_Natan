using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantes_Natan
{
    public partial class FormInserirEstudantes : Form
    {
        public FormInserirEstudantes()
        {
            InitializeComponent();
        }

        private void labelGenero_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonMasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            //Exibe uma janela para procurar a imagem

            OpenFileDialog selecionarImagem = new OpenFileDialog();

            selecionarImagem.Filter = "Selecione a foto (*.jpg; *.png; *.git)|*.jpg; *.png; *.git";

            selecionarImagem.ShowDialog();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
