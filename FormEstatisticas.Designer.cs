namespace GestorDeEstudantesT7
{
    partial class FormEstatisticas
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
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.panelTotalDeEstudantes = new System.Windows.Forms.Panel();
            this.labelTotalDeEstudantes = new System.Windows.Forms.Label();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panelMeninos.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.panelTotalDeEstudantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Location = new System.Drawing.Point(17, 232);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(330, 206);
            this.panelMeninos.TabIndex = 0;
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.RosyBrown;
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(397, 232);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(341, 206);
            this.panelMeninas.TabIndex = 1;
            // 
            // panelTotalDeEstudantes
            // 
            this.panelTotalDeEstudantes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelTotalDeEstudantes.Controls.Add(this.labelTotalDeEstudantes);
            this.panelTotalDeEstudantes.Location = new System.Drawing.Point(17, 12);
            this.panelTotalDeEstudantes.Name = "panelTotalDeEstudantes";
            this.panelTotalDeEstudantes.Size = new System.Drawing.Size(720, 202);
            this.panelTotalDeEstudantes.TabIndex = 2;
            // 
            // labelTotalDeEstudantes
            // 
            this.labelTotalDeEstudantes.AutoSize = true;
            this.labelTotalDeEstudantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDeEstudantes.Location = new System.Drawing.Point(252, 79);
            this.labelTotalDeEstudantes.Name = "labelTotalDeEstudantes";
            this.labelTotalDeEstudantes.Size = new System.Drawing.Size(216, 24);
            this.labelTotalDeEstudantes.TabIndex = 0;
            this.labelTotalDeEstudantes.Text = "Total de Estudantes: 999";
            this.labelTotalDeEstudantes.MouseEnter += new System.EventHandler(this.labelTotalDeEstudantes_MouseEnter);
            this.labelTotalDeEstudantes.MouseLeave += new System.EventHandler(this.labelTotalDeEstudantes_MouseLeave);
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninos.Location = new System.Drawing.Point(103, 85);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(128, 24);
            this.labelMeninos.TabIndex = 1;
            this.labelMeninos.Text = "Meninos: 50%";
            this.labelMeninos.MouseEnter += new System.EventHandler(this.labelMeninos_MouseEnter);
            this.labelMeninos.MouseLeave += new System.EventHandler(this.labelMeninos_MouseLeave);
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninas.Location = new System.Drawing.Point(115, 85);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(127, 24);
            this.labelMeninas.TabIndex = 2;
            this.labelMeninas.Text = "Meninas: 50%";
            this.labelMeninas.MouseEnter += new System.EventHandler(this.labelMeninas_MouseEnter);
            this.labelMeninas.MouseLeave += new System.EventHandler(this.labelMeninas_MouseLeave);
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.panelTotalDeEstudantes);
            this.Controls.Add(this.panelMeninas);
            this.Controls.Add(this.panelMeninos);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.panelTotalDeEstudantes.ResumeLayout(false);
            this.panelTotalDeEstudantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Panel panelTotalDeEstudantes;
        private System.Windows.Forms.Label labelTotalDeEstudantes;
        private System.Windows.Forms.Label labelMeninos;
        private System.Windows.Forms.Label labelMeninas;
    }
}