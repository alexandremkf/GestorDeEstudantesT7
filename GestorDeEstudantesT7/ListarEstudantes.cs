using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantesT7
{
    public partial class ListarEstudantes : Form
    {
        public ListarEstudantes()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void ListarEstudantes_Load(object sender, EventArgs e)
        {
            // Preenche o dataGridView com as informações dos estudantes.
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");

            // Impede que os dados exibidos na tabela sejam alterados.
            dataGridViewListaDeAlunos.ReadOnly = true;
            
            // Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();

            // Determina uma altura padrão para as linhas da tabela
            dataGridViewListaDeAlunos.RowTemplate.Height = 80;

            // Determina a origem dos dados da tabela.
            dataGridViewListaDeAlunos.DataSource = estudante.getEstudantes(comando);

            // Determinar qual será a coluna das imagens.
            colunaDeFotos = (DataGridViewImageColumn) dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;

            // Impede o usuário de incluir linhas
            dataGridViewListaDeAlunos.AllowUserToAddRows = false;
        }
    }
}
