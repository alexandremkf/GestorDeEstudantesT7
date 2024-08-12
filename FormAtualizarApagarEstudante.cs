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
    public partial class FormAtualizarApagarEstudante : Form
    {
        public FormAtualizarApagarEstudante()
        {
            InitializeComponent();
        }

        // Variável global do tipo Estudante, ou instância de um
        // objeto do tipo Estudante, chamado "estudante".
        Estudante estudante = new Estudante();

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

        private void buttonApagar_Click(object sender, EventArgs e)
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

        // Variável global do tipo MeuBancoDeDados...
        MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
           try
           {
                // Converte o ID da caixa de texto para número inteiro.
                int idDoAluno = Convert.ToInt32(textBoxID.Text);

                MySqlCommand comando = new MySqlCommand("SELECT `id`, `nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto` FROM `estudantes` WHERE `id`=@idDoAluno", meuBancoDeDados.getConexao);
                comando.Parameters.Add("@idDoAluno", MySqlDbType.Int32).Value = idDoAluno;

                DataTable tabela = estudante.getEstudantes(comando);

                if (tabela.Rows.Count > 0)
                {
                    // Rows[número da linha][título da coluna]. A primeira coluna é sempre a 0.
                    textBoxID.Text = tabela.Rows[0]["id"].ToString();
                    textBoxNome.Text = tabela.Rows[0]["nome"].ToString();
                    textBoxSobrenome.Text = tabela.Rows[0]["sobrenome"].ToString();
                    textBoxTelefone.Text = tabela.Rows[0]["telefone"].ToString();
                    textBoxEndereco.Text = tabela.Rows[0]["endereco"].ToString();

                    dateTimePickerNascimento.Value = (DateTime)tabela.Rows[0]["nascimento"];

                    if (tabela.Rows[0]["genero"].ToString() == "Feminino")
                    {
                        radioButtonFeminino.Checked = true;
                    }
                    else
                    {
                        radioButtonMasculino.Checked = true;
                    }

                    byte[] foto = (byte[])tabela.Rows[0]["foto"];
                    MemoryStream fotoStream = new MemoryStream(foto);
                    pictureBoxFoto.Image = Image.FromStream(fotoStream);
                }
            } catch // Exibe uma mensagem de erro caso o usuário não digite a ID.
            {
                MessageBox.Show("Digite uma ID válida!", "ID Inválida", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Impede que o usuário digite letras na caixa de texto de ID.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormAtualizarApagarEstudante_Load(object sender, EventArgs e)
        {

        }
    }
}
