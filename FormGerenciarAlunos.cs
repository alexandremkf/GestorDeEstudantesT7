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

namespace GestorDeEstudantesT7
{
    public partial class FormGerenciarAlunos : Form
    {
        public FormGerenciarAlunos()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormGerenciarAlunos_Load(object sender, EventArgs e)
        {
            // Preenche a tabela com os alunos do banco de dados.
            preecheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));
            
        }

        // Método que preenche a tabela com os alunos do banco de dados.
        public void preecheTabela(MySqlCommand comando)
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

            // Mostre o total de alunos.
            labelTotalDeAlunos.Text = "Total de Alunos: " + dataGridViewListaDeAlunos.Rows.Count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewListaDeAlunos_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[0].Value.ToString();
            textBoxNome.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[1].Value.ToString();
            textBoxSobrenome.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[2].Value.ToString();

            dateTimePickerNascimento.Value = (DateTime)dataGridViewListaDeAlunos.CurrentRow.Cells[3].Value;

            if (dataGridViewListaDeAlunos.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                radioButtonFeminino.Checked = true;
            }
            else
            {
                radioButtonMasculino.Checked = true;
            }

            textBoxTelefone.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[5].Value.ToString();
            textBoxEndereco.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[6].Value.ToString();

            byte[] image;
            image = (byte [])dataGridViewListaDeAlunos.CurrentRow.Cells[7].Value;
            MemoryStream fotoDoAluno = new MemoryStream(image);
            pictureBoxFoto.Image = Image.FromStream(fotoDoAluno);
        }

        private void buttonRedefinir_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxNome.Text = "";
            textBoxSobrenome.Text = "";
            textBoxEndereco.Text = "";
            textBoxTelefone.Text = "";
            radioButtonFeminino.Checked = true;
            dateTimePickerNascimento.Value = DateTime.Now;
            pictureBoxFoto.Image = null;
        }
    }
}
