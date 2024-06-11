using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if (selecionarImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUsuario.Image = Image.FromFile(selecionarImagem.FileName);
            }
             
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool Verificar()
        {
            if ((textBoxNome.Text.Trim() == "") ||
                (textBoxSobrenome.Text.Trim() == "") ||
                (textBoxTelefone.Text.Trim() == "") ||
                (textBoxEndereco.Text.Trim() == "") ||
                (pictureBoxUsuario.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Cria um estudante.
            Estudante estudante = new Estudante();
            //Variáveis auxiliares
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            DateTime nascimento = dateTimePickerNascimento.Value;
            string telefone = textBoxTelefone.Text;
            string endereco = textBoxEndereco.Text;
            string genero = "Feminino";

            //verifica se outro genero está selecionado
            if (radioButtonMasc.Checked)
            {
                genero = "Masculino";
            }

            MemoryStream foto = new MemoryStream();

            //Precisamos verificar se o estudante tem mais de 10 anos e menos de 100

            int anoDeNascimento = dateTimePickerNascimento.Value.Year;
            int anoAtual = DateTime.Now.Year;

            if (((anoAtual - anoDeNascimento) < 10) ||
                ((anoAtual - anoDeNascimento) > 100))
            {
                MessageBox.Show("Precisa ter entre 10 e 100 anos.",
                    "Idade inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verificar())
            {
                pictureBoxUsuario.Image.Save(foto, pictureBoxUsuario.Image.RawFormat);

                if (estudante.inserirEstudante(nome, sobrenome, nascimento, telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Novo aluno cadastro!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Aluno não cadastrado!", "Falha!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campos não preenchidos!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
