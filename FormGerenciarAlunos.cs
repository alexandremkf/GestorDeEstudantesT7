using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));
            
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

            // Mostre o total de alunos.
            labelTotalDeAlunos.Text = "Total de Alunos: " + dataGridViewListaDeAlunos.Rows.Count;
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

        private void buttonBaixarFoto_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvarArquivo = new SaveFileDialog();
            // Definir o nome do arquivo que será salvo.
            salvarArquivo.FileName = "Estudante_" + textBoxID.Text;

            // Verificar se tem imagem na caixa de imagem 
            if (pictureBoxFoto.Image == null)
            {
                MessageBox.Show("Não tem foto pra baixar.");
            }
            else
            if (salvarArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image.Save(salvarArquivo.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            // Abre janela para pesquisar a imagem no computador.
            OpenFileDialog procurarFoto = new OpenFileDialog();

            procurarFoto.Filter = "Selecione a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if (procurarFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(procurarFoto.FileName);
            }
        }

        private void buttonBuscarDado_Click(object sender, EventArgs e)
        {
            string pesquisa = "SELECT * FROM `estudantes` WHERE CONCAT" + 
                "(`nome`,`sobrenome`,`endereco`) LIKE'&"+textBoxBuscarDado.Text+"&'";
            MySqlCommand comando = new MySqlCommand(pesquisa);
            preencheTabela(comando);
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Esta linha só existe em "buttonSalvar_Click(...)"
                int id = Convert.ToInt32(textBoxID.Text);

                string nome = textBoxNome.Text;
                string sobrenome = textBoxSobrenome.Text;
                DateTime nascimento = dateTimePickerNascimento.Value;
                string telefone = textBoxTelefone.Text;
                string endereco = textBoxEndereco.Text;
                string genero = "Feminino";

                if (radioButtonMasculino.Checked == true)
                {
                    genero = "Masculino";
                }

                MemoryStream foto = new MemoryStream();

                // Verificar se o aluno tem entre 10 e 100 anos.
                int anoDeNascimento = dateTimePickerNascimento.Value.Year;
                int anoAtual = DateTime.Now.Year;

                if ((anoAtual - anoDeNascimento) < 10 || (anoAtual - anoDeNascimento) > 100)
                {
                    MessageBox.Show("O aluno precisa ter entre 10 e 100 anos.",
                        "Ano de nascimento inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (Verificar())
                {
                    pictureBoxFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);

                    if (estudante.atualizarEstudantes(id, nome, sobrenome, nascimento, telefone,
                        genero, endereco, foto))
                    {
                        MessageBox.Show("Dados salvos!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Preenche a tabela com os alunos do banco de dados.
                        preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível salvar!", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    MessageBox.Show("Existem campos não preenchidos!", "Campos não preenchidos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            try
            {
                // Referência a ID do aluno.
                int idDoAluno = Convert.ToInt32(textBoxID.Text);

                // Mostrar uma caixa de diálogo perguntando se o usuário
                // tem certeza de que quer apagar o aluno.
                if (MessageBox.Show("Tem certeza que deseja apagar o aluno?",
                    "Apagar Estudante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (estudante.apagarEstudante(idDoAluno))
                    {
                        MessageBox.Show("Aluno apagado!",
                            "Apagar Estudante", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Limpa as caixas de texto.
                        textBoxID.Text = "";
                        textBoxNome.Text = "";
                        textBoxTelefone.Text = "";
                        textBoxEndereco.Text = "";
                        dateTimePickerNascimento.Value = DateTime.Now;
                        pictureBoxFoto.Image = null;

                        // Preenche a tabela com os alunos do banco de dados.
                        preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));
                    }
                    else
                    {
                        MessageBox.Show("Aluno não apagado!",
                            "Apagar Estudante", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        bool Verificar()
        {
            if ((textBoxNome.Text.Trim() == "") ||
               (textBoxSobrenome.Text.Trim() == "") ||
               (textBoxTelefone.Text.Trim() == "") ||
               (textBoxEndereco.Text.Trim() == "") ||
               (pictureBoxFoto.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
