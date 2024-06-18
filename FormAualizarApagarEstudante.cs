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
    public partial class FormAualizarApagarEstudante : Form
    {
        public FormAualizarApagarEstudante()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            // Pesquisa a imagem no computador
            OpenFileDialog procurarFoto = new OpenFileDialog();

            procurarFoto.Filter = "Selecione a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if (procurarFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(procurarFoto.FileName);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            

            // Esta linha só existe em "buttonSalvar_Click(...)"
            int id  = Convert.ToInt32(textBoxID.Text);

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

            // Verificar se o estudante tem entre 10 a 100 anos.
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

                if (estudante.atualizarEstudantes(id, nome, sobrenome, nascimento, telefone, endereco, genero, foto))
                {
                    MessageBox.Show("Dados Salvos!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível salvar!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Existem campos não preenchidos!", "Campos não preenchidos!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Referência a ID do aluno.
            int idDoAluno = Convert.ToInt32(textBoxID.Text);

            // Mostrar uma caixa de diálogo.
            // tem certeza de que quer apagar o aluno.
            if (MessageBox.Show("Tem certeza de que quer apagar o aluno ?",
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
                    textBoxSobrenome.Text = "";
                    textBoxTelefone.Text = "";
                    textBoxEndereco.Text = "";

                }
            }
        }
    }
}
