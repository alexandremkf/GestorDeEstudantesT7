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

namespace GestorDeEstudantesT7
{
    public partial class FormImprimirAluno : Form
    {
        public FormImprimirAluno()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormImprimirAluno_Load(object sender, EventArgs e)
        {
            preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));

            if (radioButtonNao.Checked == true)
            {
                dateTimePickerDataInicial.Enabled = false;
                dateTimePickerDataFinal.Enabled = false;
            }
        }

        // Método que preenche a tabela com os alunos do banco de dados.
        public void preencheTabela(MySqlCommand comando)
        {
            // Impede que os dados exibidos na tabela sejam alterados.
            dataGridViewListaDeAlunos.ReadOnly = true;
            // Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            // Determina uma altura padrão para as linhas da tabela.
            dataGridViewListaDeAlunos.RowTemplate.Height = 80;
            // Determina a origem dos dados da tabela.
            dataGridViewListaDeAlunos.DataSource = estudante.getEstudantes(comando);
            // Determinar qual SERÁ a coluna com as imagens.
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // Impede o usuário de incluir linhas.
            dataGridViewListaDeAlunos.AllowUserToAddRows = false;
        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDataInicial.Enabled = false;
            dateTimePickerDataFinal.Enabled = false;
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDataInicial.Enabled = true;
            dateTimePickerDataFinal.Enabled = true;
        }
    }
}
