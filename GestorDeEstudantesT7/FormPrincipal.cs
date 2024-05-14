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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void estudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudante formInserirEstudante = new FormInserirEstudante();
            formInserirEstudante.Show(this);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
