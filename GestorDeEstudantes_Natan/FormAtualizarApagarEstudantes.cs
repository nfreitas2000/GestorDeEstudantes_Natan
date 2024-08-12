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
    public partial class FormAtualizarApagarEstudantes : Form
    {
       
        Estudante estudante = new Estudante();

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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Cria um estudante.
            Estudante estudante = new Estudante();
            //Variáveis auxiliares
            int id = Convert.ToInt32(textBoxID.Text);
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

                if (estudante.atualizarEstudante(id, nome, sobrenome, nascimento, telefone, genero, endereco, foto))
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
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            //Remover Estudante
            int id = Convert.ToInt32(textBoxID.Text);
            if (MessageBox.Show("Tem certeza que deseja apagar esse aluno?", "Apagar Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (estudante.apagarEstudante(id))
                {
                    MessageBox.Show("Estudante Removido!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Limpa as caixas de texto
                    textBoxID.Text = "";
                    textBoxNome.Text = "";
                }
                else
                {
                    MessageBox.Show("Estudante não removido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
} 
