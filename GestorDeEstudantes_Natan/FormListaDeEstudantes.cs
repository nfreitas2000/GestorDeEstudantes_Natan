using MySql.Data.MySqlClient;
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
            MySqlCommand comando = new MySqlCommand("SELECT * FROM ´estudantes´");
            dataGridViewListaDeEstudantes.ReadOnly = true; // Define a tabela para apenas leitura
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            dataGridViewListaDeEstudantes.RowTemplate.Height = 80; //Define a altura max da tabela para ate 80 pixels
            dataGridViewListaDeEstudantes.DataSource = estudante.pegarEstudantes(comando);
            colunaDeFotos = (DataGridViewImageColumn) dataGridViewListaDeEstudantes.Columns[7];  //Determina quem é a coluna de foto
        }
    }
}
