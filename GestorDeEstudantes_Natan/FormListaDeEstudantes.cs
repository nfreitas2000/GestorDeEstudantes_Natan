using MySql.Data.MySqlClient;
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
    public partial class FormListaDeEstudantes : Form
    {
        public FormListaDeEstudantes()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormListaDeEstudantes_Load(object sender, EventArgs e)
        {
            //Preenche a tabela com as informãções do bd
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            dataGridViewListaDeEstudantes.ReadOnly = true; // Define a tabela para apenas leitura
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            dataGridViewListaDeEstudantes.RowTemplate.Height = 80; //Define a altura max da tabela para ate 80 pixels
            dataGridViewListaDeEstudantes.DataSource = estudante.pegarEstudantes(comando);
            colunaDeFotos = (DataGridViewImageColumn) dataGridViewListaDeEstudantes.Columns[7];  //Determina quem é a coluna de foto
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch; //Estica a coluna de foto
            dataGridViewListaDeEstudantes.AllowUserToAddRows = false;
        }

        private void dataGridViewListaDeEstudantes_DoubleClick(object sender, EventArgs e)
        {
            //Abre as informações do aluno selecionado em uma nova janela.
            FormAtualizarApagarEstudantes formAtualizarApagarEstudantes = new FormAtualizarApagarEstudantes();
            formAtualizarApagarEstudantes.textBoxID.Text = dataGridViewListaDeEstudantes.CurrentRow.Cells[0].Value.ToString();
            formAtualizarApagarEstudantes.textBoxNome.Text = dataGridViewListaDeEstudantes.CurrentRow.Cells[1].Value.ToString();
            formAtualizarApagarEstudantes.textBoxSobrenome.Text = dataGridViewListaDeEstudantes.CurrentRow.Cells[2].Value.ToString();
            formAtualizarApagarEstudantes.dateTimePickerNascimento.Value = (DateTime) dataGridViewListaDeEstudantes.CurrentRow.Cells[3].Value;
            if (dataGridViewListaDeEstudantes.CurrentRow.Cells[4].Value.ToString() == "Masculino")
            {
                formAtualizarApagarEstudantes.radioButtonMasc.Checked = true;
            }
            else
            {
                formAtualizarApagarEstudantes.radioButtonFem.Checked = true;
            }
            formAtualizarApagarEstudantes.textBoxTelefone.Text = dataGridViewListaDeEstudantes.CurrentRow.Cells[5].Value.ToString();
            formAtualizarApagarEstudantes.textBoxEndereco.Text = dataGridViewListaDeEstudantes.CurrentRow.Cells[6].Value.ToString();

            //foto do aluno
            byte[] imagem;
            imagem = (byte[]) dataGridViewListaDeEstudantes.CurrentRow.Cells[7].Value;
            MemoryStream foto = new MemoryStream(imagem);
            formAtualizarApagarEstudantes.pictureBoxUsuario.Image = Image.FromStream(foto);


            formAtualizarApagarEstudantes.Show();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            //Atualiza a lista de Estudantes
        }

        private void dataGridViewListaDeEstudantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
