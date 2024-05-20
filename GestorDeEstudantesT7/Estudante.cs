using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstudantesT7
{
    internal class Estudante
    {
        MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

        public bool inserirEstudante(string nome, string sobrenome, DateTime nascimento,
            string telefone, string genero, string endereco, MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`id`, `nome`, `sobrenome`, `nascimento`, `genero`, `Telefone`, `endereco`, `foto`) VALUES (@nome,@sobrenome,@nascimento,@genero,@telefone,@endereco,@foto)", meuBancoDeDados.getConexao);
        
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nascimento", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@genero", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@endereco", MySqlDbType.Text).Value = endereco;
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto;

            meuBancoDeDados.abrirConexao();

            if (comando.ExecuteNonQuery() == 1)
            {
                meuBancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                meuBancoDeDados.fecharConexao();
                return false;
            }
        }
    }
}
