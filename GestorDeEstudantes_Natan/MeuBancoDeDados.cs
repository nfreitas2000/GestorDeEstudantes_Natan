using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantes_Natan
{
    internal class MeuBancoDeDados
    {
        //Criação de um objeto "conexao", do tipo "MySqlConnection", na classe "MeuBancoDeDados"
        //que recebe os dados do banco de dados (localização nas aspas)
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudantes_bd_t6");
    }
}

