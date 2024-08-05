namespace GestorDeEstudantesT7
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoEstudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEstudantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRemoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pontosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudanteToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.pontosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estudanteToolStripMenuItem
            // 
            this.estudanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoEstudanteToolStripMenuItem,
            this.listaDeEstudantToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.editarRemoverToolStripMenuItem,
            this.gerenciarAlunosToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.estudanteToolStripMenuItem.Name = "estudanteToolStripMenuItem";
            this.estudanteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.estudanteToolStripMenuItem.Text = "Alunos";
            this.estudanteToolStripMenuItem.Click += new System.EventHandler(this.estudanteToolStripMenuItem_Click);
            // 
            // novoEstudanteToolStripMenuItem
            // 
            this.novoEstudanteToolStripMenuItem.Name = "novoEstudanteToolStripMenuItem";
            this.novoEstudanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoEstudanteToolStripMenuItem.Text = "Novo Aluno";
            this.novoEstudanteToolStripMenuItem.Click += new System.EventHandler(this.novoEstudanteToolStripMenuItem_Click);
            // 
            // listaDeEstudantToolStripMenuItem
            // 
            this.listaDeEstudantToolStripMenuItem.Name = "listaDeEstudantToolStripMenuItem";
            this.listaDeEstudantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeEstudantToolStripMenuItem.Text = "Listar Alunos";
            this.listaDeEstudantToolStripMenuItem.Click += new System.EventHandler(this.listaDeEstudantToolStripMenuItem_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            this.estatísticasToolStripMenuItem.Click += new System.EventHandler(this.estatísticasToolStripMenuItem_Click);
            // 
            // editarRemoverToolStripMenuItem
            // 
            this.editarRemoverToolStripMenuItem.Name = "editarRemoverToolStripMenuItem";
            this.editarRemoverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarRemoverToolStripMenuItem.Text = "Editar/Remover";
            this.editarRemoverToolStripMenuItem.Click += new System.EventHandler(this.editarRemoverToolStripMenuItem_Click);
            // 
            // gerenciarAlunosToolStripMenuItem
            // 
            this.gerenciarAlunosToolStripMenuItem.Name = "gerenciarAlunosToolStripMenuItem";
            this.gerenciarAlunosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenciarAlunosToolStripMenuItem.Text = "Gerenciar Alunos";
            this.gerenciarAlunosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarAlunosToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // pontosToolStripMenuItem
            // 
            this.pontosToolStripMenuItem.Name = "pontosToolStripMenuItem";
            this.pontosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pontosToolStripMenuItem.Text = "Pontos";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoEstudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEstudantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pontosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRemoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
    }
}