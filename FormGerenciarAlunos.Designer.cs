namespace GestorDeEstudantesT7
{
    partial class FormGerenciarAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarAlunos));
            this.buttonEnviarFoto = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelFoto = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonBaixarFoto = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.dataGridViewListaDeAlunos = new System.Windows.Forms.DataGridView();
            this.labelBuscarDado = new System.Windows.Forms.Label();
            this.textBoxBuscarDado = new System.Windows.Forms.TextBox();
            this.buttonBuscarDado = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonRedefinir = new System.Windows.Forms.Button();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelTotalDeAlunos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnviarFoto
            // 
            this.buttonEnviarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviarFoto.Location = new System.Drawing.Point(149, 447);
            this.buttonEnviarFoto.Name = "buttonEnviarFoto";
            this.buttonEnviarFoto.Size = new System.Drawing.Size(65, 40);
            this.buttonEnviarFoto.TabIndex = 49;
            this.buttonEnviarFoto.Text = "Enviar Foto";
            this.buttonEnviarFoto.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(27, 19);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 17);
            this.labelID.TabIndex = 46;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(134, 16);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(87, 20);
            this.textBoxID.TabIndex = 45;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(229, 7);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(90, 35);
            this.buttonBuscar.TabIndex = 44;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Location = new System.Drawing.Point(116, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(113, 18);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Checked = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(19, 19);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(27, 143);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(62, 17);
            this.labelGenero.TabIndex = 36;
            this.labelGenero.Text = "Gênero";
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoto.Location = new System.Drawing.Point(26, 283);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(40, 17);
            this.labelFoto.TabIndex = 43;
            this.labelFoto.Text = "Foto";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.Image")));
            this.pictureBoxFoto.Location = new System.Drawing.Point(149, 283);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(158, 158);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 42;
            this.pictureBoxFoto.TabStop = false;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(26, 220);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(77, 17);
            this.labelEndereco.TabIndex = 41;
            this.labelEndereco.Text = "Endereço";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(134, 217);
            this.textBoxEndereco.Multiline = true;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(182, 48);
            this.textBoxEndereco.TabIndex = 40;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(26, 194);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(72, 17);
            this.labelTelefone.TabIndex = 39;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(134, 191);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(182, 20);
            this.textBoxTelefone.TabIndex = 38;
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(134, 100);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(87, 20);
            this.dateTimePickerNascimento.TabIndex = 35;
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNascimento.Location = new System.Drawing.Point(26, 104);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(92, 17);
            this.labelNascimento.TabIndex = 34;
            this.labelNascimento.Text = "Nascimento";
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobrenome.Location = new System.Drawing.Point(26, 77);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(90, 17);
            this.labelSobrenome.TabIndex = 33;
            this.labelSobrenome.Text = "Sobrenome";
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(134, 74);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(182, 20);
            this.textBoxSobrenome.TabIndex = 32;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(26, 51);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(49, 17);
            this.labelNome.TabIndex = 31;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(134, 48);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(182, 20);
            this.textBoxNome.TabIndex = 30;
            // 
            // buttonBaixarFoto
            // 
            this.buttonBaixarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaixarFoto.Location = new System.Drawing.Point(242, 446);
            this.buttonBaixarFoto.Name = "buttonBaixarFoto";
            this.buttonBaixarFoto.Size = new System.Drawing.Size(65, 40);
            this.buttonBaixarFoto.TabIndex = 50;
            this.buttonBaixarFoto.Text = "Baixar Foto";
            this.buttonBaixarFoto.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(373, 492);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(287, 55);
            this.buttonAtualizar.TabIndex = 52;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListaDeAlunos
            // 
            this.dataGridViewListaDeAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaDeAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeAlunos.Location = new System.Drawing.Point(373, 51);
            this.dataGridViewListaDeAlunos.Name = "dataGridViewListaDeAlunos";
            this.dataGridViewListaDeAlunos.Size = new System.Drawing.Size(495, 435);
            this.dataGridViewListaDeAlunos.TabIndex = 51;
            this.dataGridViewListaDeAlunos.Click += new System.EventHandler(this.dataGridViewListaDeAlunos_Click);
            // 
            // labelBuscarDado
            // 
            this.labelBuscarDado.AutoSize = true;
            this.labelBuscarDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarDado.Location = new System.Drawing.Point(370, 19);
            this.labelBuscarDado.Name = "labelBuscarDado";
            this.labelBuscarDado.Size = new System.Drawing.Size(186, 17);
            this.labelBuscarDado.TabIndex = 55;
            this.labelBuscarDado.Text = "Insira dado para buscar:";
            this.labelBuscarDado.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxBuscarDado
            // 
            this.textBoxBuscarDado.Location = new System.Drawing.Point(562, 18);
            this.textBoxBuscarDado.Name = "textBoxBuscarDado";
            this.textBoxBuscarDado.Size = new System.Drawing.Size(183, 20);
            this.textBoxBuscarDado.TabIndex = 54;
            // 
            // buttonBuscarDado
            // 
            this.buttonBuscarDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarDado.Location = new System.Drawing.Point(751, 9);
            this.buttonBuscarDado.Name = "buttonBuscarDado";
            this.buttonBuscarDado.Size = new System.Drawing.Size(90, 35);
            this.buttonBuscarDado.TabIndex = 53;
            this.buttonBuscarDado.Text = "Buscar";
            this.buttonBuscarDado.UseVisualStyleBackColor = true;
            this.buttonBuscarDado.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(196, 502);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(80, 41);
            this.buttonRemover.TabIndex = 57;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonRedefinir
            // 
            this.buttonRedefinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedefinir.Location = new System.Drawing.Point(282, 502);
            this.buttonRedefinir.Name = "buttonRedefinir";
            this.buttonRedefinir.Size = new System.Drawing.Size(77, 41);
            this.buttonRedefinir.TabIndex = 56;
            this.buttonRedefinir.Text = "Redefinir";
            this.buttonRedefinir.UseVisualStyleBackColor = true;
            this.buttonRedefinir.Click += new System.EventHandler(this.buttonRedefinir_Click);
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncluir.Location = new System.Drawing.Point(12, 502);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(80, 41);
            this.buttonIncluir.TabIndex = 59;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(98, 502);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(73, 41);
            this.buttonSalvar.TabIndex = 58;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // labelTotalDeAlunos
            // 
            this.labelTotalDeAlunos.AutoSize = true;
            this.labelTotalDeAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDeAlunos.Location = new System.Drawing.Point(697, 515);
            this.labelTotalDeAlunos.Name = "labelTotalDeAlunos";
            this.labelTotalDeAlunos.Size = new System.Drawing.Size(159, 17);
            this.labelTotalDeAlunos.TabIndex = 60;
            this.labelTotalDeAlunos.Text = "Total de Alunos: 999";
            // 
            // FormGerenciarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 559);
            this.Controls.Add(this.labelTotalDeAlunos);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonRedefinir);
            this.Controls.Add(this.labelBuscarDado);
            this.Controls.Add(this.textBoxBuscarDado);
            this.Controls.Add(this.buttonBuscarDado);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridViewListaDeAlunos);
            this.Controls.Add(this.buttonBaixarFoto);
            this.Controls.Add(this.buttonEnviarFoto);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormGerenciarAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA - Gerenciar Alunos";
            this.Load += new System.EventHandler(this.FormGerenciarAlunos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnviarFoto;
        private System.Windows.Forms.Label labelID;
        internal System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton radioButtonFeminino;
        internal System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelFoto;
        internal System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label labelEndereco;
        internal System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelTelefone;
        internal System.Windows.Forms.TextBox textBoxTelefone;
        internal System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelSobrenome;
        internal System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label labelNome;
        internal System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonBaixarFoto;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.DataGridView dataGridViewListaDeAlunos;
        private System.Windows.Forms.Label labelBuscarDado;
        internal System.Windows.Forms.TextBox textBoxBuscarDado;
        private System.Windows.Forms.Button buttonBuscarDado;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonRedefinir;
        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelTotalDeAlunos;
    }
}