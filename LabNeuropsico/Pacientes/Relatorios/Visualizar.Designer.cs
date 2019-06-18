namespace LabNeuropsico.Pacientes.Relatorios
{
    partial class Visualizar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.controlRelatorio = new System.Windows.Forms.TabControl();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtQueixa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFimAval = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInicioAval = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabAvaliacoes = new System.Windows.Forms.TabPage();
            this.checkExcluido = new System.Windows.Forms.CheckBox();
            this.btnExcluirRelatorio = new System.Windows.Forms.Button();
            this.btnCadastrarAvaliacao = new System.Windows.Forms.Button();
            this.lblNenhum = new System.Windows.Forms.Label();
            this.dgvAvaliacoes = new System.Windows.Forms.DataGridView();
            this.btnVisualizarAvaliacao = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumRelatorio = new System.Windows.Forms.Label();
            this.controlRelatorio.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.tabAvaliacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaliacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(495, 372);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 32);
            this.btnFechar.TabIndex = 85;
            this.btnFechar.Text = "&Sair";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 372);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 32);
            this.btnVoltar.TabIndex = 84;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(268, 31);
            this.label15.TabIndex = 86;
            this.label15.Text = "Visualizar Relatório";
            // 
            // controlRelatorio
            // 
            this.controlRelatorio.Controls.Add(this.tabDados);
            this.controlRelatorio.Controls.Add(this.tabAvaliacoes);
            this.controlRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlRelatorio.HotTrack = true;
            this.controlRelatorio.Location = new System.Drawing.Point(18, 93);
            this.controlRelatorio.Multiline = true;
            this.controlRelatorio.Name = "controlRelatorio";
            this.controlRelatorio.SelectedIndex = 0;
            this.controlRelatorio.Size = new System.Drawing.Size(550, 273);
            this.controlRelatorio.TabIndex = 83;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.btnExcluir);
            this.tabDados.Controls.Add(this.btnAlterar);
            this.tabDados.Controls.Add(this.txtQueixa);
            this.tabDados.Controls.Add(this.label12);
            this.tabDados.Controls.Add(this.lblFimAval);
            this.tabDados.Controls.Add(this.label5);
            this.tabDados.Controls.Add(this.lblInicioAval);
            this.tabDados.Controls.Add(this.label3);
            this.tabDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDados.Location = new System.Drawing.Point(4, 24);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(542, 245);
            this.tabDados.TabIndex = 0;
            this.tabDados.Text = "Dados";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(130, 100);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(69, 38);
            this.btnExcluir.TabIndex = 86;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(30, 100);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 38);
            this.btnAlterar.TabIndex = 85;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtQueixa
            // 
            this.txtQueixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueixa.Location = new System.Drawing.Point(271, 42);
            this.txtQueixa.Multiline = true;
            this.txtQueixa.Name = "txtQueixa";
            this.txtQueixa.ReadOnly = true;
            this.txtQueixa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueixa.Size = new System.Drawing.Size(247, 60);
            this.txtQueixa.TabIndex = 84;
            this.txtQueixa.Text = "Queixa clínica";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(268, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "Queixa clínica";
            // 
            // lblFimAval
            // 
            this.lblFimAval.AutoSize = true;
            this.lblFimAval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFimAval.Location = new System.Drawing.Point(156, 42);
            this.lblFimAval.Name = "lblFimAval";
            this.lblFimAval.Size = new System.Drawing.Size(82, 17);
            this.lblFimAval.TabIndex = 74;
            this.lblFimAval.Text = "dd/mm/yyyy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Fim da Avaliação";
            // 
            // lblInicioAval
            // 
            this.lblInicioAval.AutoSize = true;
            this.lblInicioAval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioAval.Location = new System.Drawing.Point(27, 42);
            this.lblInicioAval.Name = "lblInicioAval";
            this.lblInicioAval.Size = new System.Drawing.Size(82, 17);
            this.lblInicioAval.TabIndex = 72;
            this.lblInicioAval.Text = "dd/mm/yyyy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Início da Avaliação";
            // 
            // tabAvaliacoes
            // 
            this.tabAvaliacoes.Controls.Add(this.checkExcluido);
            this.tabAvaliacoes.Controls.Add(this.btnExcluirRelatorio);
            this.tabAvaliacoes.Controls.Add(this.btnCadastrarAvaliacao);
            this.tabAvaliacoes.Controls.Add(this.lblNenhum);
            this.tabAvaliacoes.Controls.Add(this.dgvAvaliacoes);
            this.tabAvaliacoes.Controls.Add(this.btnVisualizarAvaliacao);
            this.tabAvaliacoes.Location = new System.Drawing.Point(4, 24);
            this.tabAvaliacoes.Name = "tabAvaliacoes";
            this.tabAvaliacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvaliacoes.Size = new System.Drawing.Size(542, 245);
            this.tabAvaliacoes.TabIndex = 1;
            this.tabAvaliacoes.Text = "Avaliações";
            this.tabAvaliacoes.UseVisualStyleBackColor = true;
            this.tabAvaliacoes.Layout += new System.Windows.Forms.LayoutEventHandler(this.tabAvaliacoes_Layout);
            // 
            // checkExcluido
            // 
            this.checkExcluido.AutoSize = true;
            this.checkExcluido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkExcluido.Location = new System.Drawing.Point(345, 220);
            this.checkExcluido.Name = "checkExcluido";
            this.checkExcluido.Size = new System.Drawing.Size(191, 19);
            this.checkExcluido.TabIndex = 9;
            this.checkExcluido.Text = "Mostrar avaliações excluídas?";
            this.checkExcluido.UseVisualStyleBackColor = true;
            this.checkExcluido.CheckedChanged += new System.EventHandler(this.checkExcluido_CheckedChanged);
            // 
            // btnExcluirRelatorio
            // 
            this.btnExcluirRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirRelatorio.Location = new System.Drawing.Point(403, 176);
            this.btnExcluirRelatorio.Name = "btnExcluirRelatorio";
            this.btnExcluirRelatorio.Size = new System.Drawing.Size(133, 38);
            this.btnExcluirRelatorio.TabIndex = 8;
            this.btnExcluirRelatorio.Text = "Excluir selecionada";
            this.btnExcluirRelatorio.UseVisualStyleBackColor = true;
            this.btnExcluirRelatorio.Click += new System.EventHandler(this.btnExcluirAvaliacao_Click);
            // 
            // btnCadastrarAvaliacao
            // 
            this.btnCadastrarAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAvaliacao.Location = new System.Drawing.Point(6, 176);
            this.btnCadastrarAvaliacao.Name = "btnCadastrarAvaliacao";
            this.btnCadastrarAvaliacao.Size = new System.Drawing.Size(173, 38);
            this.btnCadastrarAvaliacao.TabIndex = 6;
            this.btnCadastrarAvaliacao.Text = "&Cadastrar Avaliação";
            this.btnCadastrarAvaliacao.UseVisualStyleBackColor = true;
            this.btnCadastrarAvaliacao.Click += new System.EventHandler(this.btnCadastrarAvaliacao_Click);
            // 
            // lblNenhum
            // 
            this.lblNenhum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNenhum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNenhum.Location = new System.Drawing.Point(131, 71);
            this.lblNenhum.Name = "lblNenhum";
            this.lblNenhum.Size = new System.Drawing.Size(280, 41);
            this.lblNenhum.TabIndex = 88;
            this.lblNenhum.Text = "Nenhuma avaliação registrada!";
            this.lblNenhum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNenhum.Visible = false;
            // 
            // dgvAvaliacoes
            // 
            this.dgvAvaliacoes.AllowUserToAddRows = false;
            this.dgvAvaliacoes.AllowUserToDeleteRows = false;
            this.dgvAvaliacoes.AllowUserToResizeRows = false;
            this.dgvAvaliacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvaliacoes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAvaliacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvaliacoes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvaliacoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAvaliacoes.Location = new System.Drawing.Point(6, 6);
            this.dgvAvaliacoes.Name = "dgvAvaliacoes";
            this.dgvAvaliacoes.RowHeadersVisible = false;
            this.dgvAvaliacoes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAvaliacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvaliacoes.ShowCellErrors = false;
            this.dgvAvaliacoes.ShowEditingIcon = false;
            this.dgvAvaliacoes.ShowRowErrors = false;
            this.dgvAvaliacoes.Size = new System.Drawing.Size(530, 164);
            this.dgvAvaliacoes.TabIndex = 5;
            this.dgvAvaliacoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvaliacoes_CellDoubleClick);
            // 
            // btnVisualizarAvaliacao
            // 
            this.btnVisualizarAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarAvaliacao.Location = new System.Drawing.Point(237, 176);
            this.btnVisualizarAvaliacao.Name = "btnVisualizarAvaliacao";
            this.btnVisualizarAvaliacao.Size = new System.Drawing.Size(160, 38);
            this.btnVisualizarAvaliacao.TabIndex = 7;
            this.btnVisualizarAvaliacao.Text = "Visualizar selecionada";
            this.btnVisualizarAvaliacao.UseVisualStyleBackColor = true;
            this.btnVisualizarAvaliacao.Click += new System.EventHandler(this.btnVisualizarAvaliacao_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(19, 68);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(124, 17);
            this.lblNome.TabIndex = 70;
            this.lblNome.Text = "Nome do Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nome do Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Num. relatório";
            // 
            // lblNumRelatorio
            // 
            this.lblNumRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRelatorio.Location = new System.Drawing.Point(398, 68);
            this.lblNumRelatorio.Name = "lblNumRelatorio";
            this.lblNumRelatorio.Size = new System.Drawing.Size(166, 17);
            this.lblNumRelatorio.TabIndex = 70;
            this.lblNumRelatorio.Text = "Num. relatório";
            this.lblNumRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 416);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.controlRelatorio);
            this.Controls.Add(this.lblNumRelatorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Visualizar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Relatório";
            this.Load += new System.EventHandler(this.Visualizar_Load);
            this.controlRelatorio.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.tabAvaliacoes.ResumeLayout(false);
            this.tabAvaliacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaliacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl controlRelatorio;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAvaliacoes;
        private System.Windows.Forms.CheckBox checkExcluido;
        private System.Windows.Forms.Button btnExcluirRelatorio;
        private System.Windows.Forms.Button btnCadastrarAvaliacao;
        private System.Windows.Forms.Label lblNenhum;
        private System.Windows.Forms.DataGridView dgvAvaliacoes;
        private System.Windows.Forms.Button btnVisualizarAvaliacao;
        private System.Windows.Forms.Label lblFimAval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInicioAval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQueixa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumRelatorio;
    }
}