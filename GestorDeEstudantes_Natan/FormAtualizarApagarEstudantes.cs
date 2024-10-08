﻿using MySql.Data.MySqlClient;
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
            try
            {//Cria um estudante.
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
            catch
            {
                MessageBox.Show("Não foi possivel salvar.", "Dados inválida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            try
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
                        textBoxSobrenome.Text = "";
                        textBoxTelefone.Text = "";
                        textBoxEndereco.Text = "";
                        dateTimePickerNascimento.Value = DateTime.Now;
                        pictureBoxUsuario.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel excluir o estudante.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Estudante não removido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                //Busca estudante pela ID.
                //Salva a ID convertida para inteira.
                int id = Convert.ToInt32(textBoxID.Text);

                MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

                MySqlCommand command = new MySqlCommand("SELECT `id`, `nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto` FROM `estudantes` WHERE `id`=" + id, meuBancoDeDados.getConexao);

                DataTable tabela = estudante.pegarEstudantes(command);

                if (tabela.Rows.Count > 0)
                {
                    textBoxNome.Text = tabela.Rows[0]["nome"].ToString();
                    textBoxSobrenome.Text = tabela.Rows[0]["sobrenome"].ToString();
                    dateTimePickerNascimento.Value = (DateTime)tabela.Rows[0]["nascimento"];
                    if (tabela.Rows[0]["genero"].ToString() == "Feminino")
                    {
                        radioButtonFem.Checked = true;
                    }
                    else
                    {
                        radioButtonMasc.Checked = true;
                    }
                    textBoxTelefone.Text = tabela.Rows[0]["telefone"].ToString();
                    textBoxEndereco.Text = tabela.Rows[0]["endereco"].ToString();
                    //A Foto
                    byte[] imagem = (byte[])tabela.Rows[0]["foto"];
                    //Objeto intermediario entre a foto que esta na tabela
                    //e a foto que esta salva no banco de dados
                    MemoryStream fotoDoAluno = new MemoryStream(imagem);
                    pictureBoxUsuario.Image = Image.FromStream(fotoDoAluno);
                }
            }
            catch
            {
                MessageBox.Show("Digite uma ID válida.", "ID inválida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
           
        }

        private void textBoxID_TextChanged(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
} 
