namespace LabNeuropsico.Pacientes
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVisualizarPaciente = new System.Windows.Forms.Button();
            this.btnConsultaGeral = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacientes";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(19, 86);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(166, 41);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar &Novo";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVisualizarPaciente
            // 
            this.btnVisualizarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarPaciente.Location = new System.Drawing.Point(19, 133);
            this.btnVisualizarPaciente.Name = "btnVisualizarPaciente";
            this.btnVisualizarPaciente.Size = new System.Drawing.Size(166, 41);
            this.btnVisualizarPaciente.TabIndex = 5;
            this.btnVisualizarPaciente.Text = "Visualizar &Paciente";
            this.btnVisualizarPaciente.UseVisualStyleBackColor = true;
            this.btnVisualizarPaciente.Click += new System.EventHandler(this.btnVisualizarPaciente_Click);
            // 
            // btnConsultaGeral
            // 
            this.btnConsultaGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGeral.Location = new System.Drawing.Point(19, 180);
            this.btnConsultaGeral.Name = "btnConsultaGeral";
            this.btnConsultaGeral.Size = new System.Drawing.Size(166, 41);
            this.btnConsultaGeral.TabIndex = 6;
            this.btnConsultaGeral.Text = "Consulta &Geral";
            this.btnConsultaGeral.UseVisualStyleBackColor = true;
            this.btnConsultaGeral.Click += new System.EventHandler(this.btnConsultaGeral_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(471, 406);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 32);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "&Sair";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 406);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 32);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConsultaGeral);
            this.Controls.Add(this.btnVisualizarPaciente);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVisualizarPaciente;
        private System.Windows.Forms.Button btnConsultaGeral;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnVoltar;
    }
}