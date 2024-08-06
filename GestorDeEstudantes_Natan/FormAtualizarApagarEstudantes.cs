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
    public partial class FormAtualizarApagarEstudantes : Form
    {
        public FormAtualizarApagarEstudantes()
        {
            InitializeComponent();
        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarImagem = new OpenFileDialog();

            selecionarImagem.Filter = "Selecione a foto (*.jpg; *.png; *.git)|*.jpg; *.png; *.git";

            selecionarImagem.ShowDialog();

            if (selecionarImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUsuario.Image = Image.FromFile(selecionarImagem.FileName);
            }
        }

        private void pictureBoxUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
