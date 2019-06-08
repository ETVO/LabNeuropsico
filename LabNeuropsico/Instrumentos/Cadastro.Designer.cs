namespace LabNeuropsico.Instrumentos
{
    partial class Cadastro
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
            this.btnNovoCampo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCampo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoCampo = new System.Windows.Forms.ComboBox();
            this.btnExcluirCampo = new System.Windows.Forms.Button();
            this.btnExcluirTodos = new System.Windows.Forms.Button();
            this.lblNenhum = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNomeInstrumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoAval = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoCampo
            // 
            this.btnNovoCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCampo.Location = new System.Drawing.Point(482, 129);
            this.btnNovoCampo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovoCampo.Name = "btnNovoCampo";
            this.btnNovoCampo.Size = new System.Drawing.Size(77, 25);
            this.btnNovoCampo.TabIndex = 4;
            this.btnNovoCampo.Text = "Adicionar";
            this.btnNovoCampo.UseVisualStyleBackColor = true;
            this.btnNovoCampo.Click += new System.EventHandler(this.btnNovoCampo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 1;
            this.label1.Tag = "1";
            this.label1.Text = "Campos do Instrumento";
            // 
            // dgvCampos
            // 
            this.dgvCampos.AllowUserToAddRows = false;
            this.dgvCampos.AllowUserToDeleteRows = false;
            this.dgvCampos.AllowUserToResizeRows = false;
            this.dgvCampos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCampos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCampos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCampos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCampos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCampos.Location = new System.Drawing.Point(264, 159);
            this.dgvCampos.MultiSelect = false;
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.RowHeadersVisible = false;
            this.dgvCampos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCampos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCampos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCampos.ShowCellErrors = false;
            this.dgvCampos.ShowEditingIcon = false;
            this.dgvCampos.ShowRowErrors = false;
            this.dgvCampos.Size = new System.Drawing.Size(295, 148);
            this.dgvCampos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 89;
            this.label2.Text = "Nome";
            // 
            // txtNomeCampo
            // 
            this.txtNomeCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCampo.Location = new System.Drawing.Point(264, 130);
            this.txtNomeCampo.Name = "txtNomeCampo";
            this.txtNomeCampo.Size = new System.Drawing.Size(100, 23);
            this.txtNomeCampo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Tipo de entrada";
            // 
            // cmbTipoCampo
            // 
            this.cmbTipoCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCampo.FormattingEnabled = true;
            this.cmbTipoCampo.Items.AddRange(new object[] {
            "Data",
            "Número inteiro",
            "Número decimal",
            "Texto"});
            this.cmbTipoCampo.Location = new System.Drawing.Point(373, 130);
            this.cmbTipoCampo.Name = "cmbTipoCampo";
            this.cmbTipoCampo.Size = new System.Drawing.Size(100, 23);
            this.cmbTipoCampo.TabIndex = 3;
            // 
            // btnExcluirCampo
            // 
            this.btnExcluirCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCampo.Location = new System.Drawing.Point(426, 313);
            this.btnExcluirCampo.Name = "btnExcluirCampo";
            this.btnExcluirCampo.Size = new System.Drawing.Size(133, 32);
            this.btnExcluirCampo.TabIndex = 7;
            this.btnExcluirCampo.Text = "Excluir selecionado";
            this.btnExcluirCampo.UseVisualStyleBackColor = true;
            this.btnExcluirCampo.Click += new System.EventHandler(this.btnExcluirCampo_Click);
            // 
            // btnExcluirTodos
            // 
            this.btnExcluirTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTodos.Location = new System.Drawing.Point(329, 313);
            this.btnExcluirTodos.Name = "btnExcluirTodos";
            this.btnExcluirTodos.Size = new System.Drawing.Size(91, 32);
            this.btnExcluirTodos.TabIndex = 6;
            this.btnExcluirTodos.Text = "Excluir todos";
            this.btnExcluirTodos.UseVisualStyleBackColor = true;
            this.btnExcluirTodos.Click += new System.EventHandler(this.btnExcluirTodos_Click);
            // 
            // lblNenhum
            // 
            this.lblNenhum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNenhum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNenhum.Location = new System.Drawing.Point(295, 220);
            this.lblNenhum.Name = "lblNenhum";
            this.lblNenhum.Size = new System.Drawing.Size(233, 37);
            this.lblNenhum.TabIndex = 95;
            this.lblNenhum.Text = "Nenhum campo registrado";
            this.lblNenhum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNenhum.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(45, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 13);
            this.label22.TabIndex = 98;
            this.label22.Text = "campos obrigatórios";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Miriam Mono CLM", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(142, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 12);
            this.label21.TabIndex = 97;
            this.label21.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(351, 31);
            this.label15.TabIndex = 96;
            this.label15.Text = "Cadastro de Instrumentos";
            // 
            // txtNomeInstrumento
            // 
            this.txtNomeInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeInstrumento.Location = new System.Drawing.Point(46, 130);
            this.txtNomeInstrumento.Name = "txtNomeInstrumento";
            this.txtNomeInstrumento.Size = new System.Drawing.Size(192, 23);
            this.txtNomeInstrumento.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "Nome do Instrumento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 101;
            this.label5.Text = "Tipo de Avaliação";
            // 
            // cmbTipoAval
            // 
            this.cmbTipoAval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAval.FormattingEnabled = true;
            this.cmbTipoAval.Items.AddRange(new object[] {
            "Intelectual",
            "Psicomotora",
            "Cognitiva",
            "Comportamental",
            "Executiva"});
            this.cmbTipoAval.Location = new System.Drawing.Point(46, 190);
            this.cmbTipoAval.Name = "cmbTipoAval";
            this.cmbTipoAval.Size = new System.Drawing.Size(192, 23);
            this.cmbTipoAval.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(57, 344);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 40);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(175, 344);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 40);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 104;
            this.label6.Tag = "1";
            this.label6.Text = "Instrumento";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(502, 399);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 32);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "&Sair";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 399);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 32);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Miriam Mono CLM", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(415, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 107;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Miriam Mono CLM", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(142, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 108;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Miriam Mono CLM", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(165, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 109;
            this.label9.Text = "*";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(587, 443);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeInstrumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblNenhum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirTodos);
            this.Controls.Add(this.btnExcluirCampo);
            this.Controls.Add(this.cmbTipoAval);
            this.Controls.Add(this.cmbTipoCampo);
            this.Controls.Add(this.txtNomeCampo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCampos);
            this.Controls.Add(this.btnNovoCampo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Instrumentos";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovoCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCampo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoCampo;
        private System.Windows.Forms.Button btnExcluirCampo;
        private System.Windows.Forms.Button btnExcluirTodos;
        private System.Windows.Forms.Label lblNenhum;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNomeInstrumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoAval;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}