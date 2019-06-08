namespace LabNeuropsico.Pacientes
{
    partial class ConsultaGeral
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
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkNome = new System.Windows.Forms.CheckBox();
            this.checkCondicao = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkFOB = new System.Windows.Forms.CheckBox();
            this.checkHRAC = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkEstrangeiro = new System.Windows.Forms.CheckBox();
            this.checkBrasileiro = new System.Windows.Forms.CheckBox();
            this.checkExcluido = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblNenhum = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(61, 106);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(557, 23);
            this.txtBusca.TabIndex = 2;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(386, 31);
            this.label15.TabIndex = 73;
            this.label15.Text = "Consulta Geral de Pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Modo de busca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = "Filtros:";
            // 
            // checkNome
            // 
            this.checkNome.AutoSize = true;
            this.checkNome.Checked = true;
            this.checkNome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNome.Location = new System.Drawing.Point(169, 87);
            this.checkNome.Name = "checkNome";
            this.checkNome.Size = new System.Drawing.Size(54, 17);
            this.checkNome.TabIndex = 1;
            this.checkNome.Text = "Nome";
            this.checkNome.UseVisualStyleBackColor = true;
            this.checkNome.CheckedChanged += new System.EventHandler(this.checkNome_CheckedChanged);
            // 
            // checkCondicao
            // 
            this.checkCondicao.AutoSize = true;
            this.checkCondicao.Location = new System.Drawing.Point(229, 87);
            this.checkCondicao.Name = "checkCondicao";
            this.checkCondicao.Size = new System.Drawing.Size(119, 17);
            this.checkCondicao.TabIndex = 1;
            this.checkCondicao.Text = "Diagnóstico médico";
            this.checkCondicao.UseVisualStyleBackColor = true;
            this.checkCondicao.CheckedChanged += new System.EventHandler(this.checkCondicao_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Hospital";
            // 
            // checkFOB
            // 
            this.checkFOB.AutoSize = true;
            this.checkFOB.Checked = true;
            this.checkFOB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFOB.Location = new System.Drawing.Point(128, 156);
            this.checkFOB.Name = "checkFOB";
            this.checkFOB.Size = new System.Drawing.Size(47, 17);
            this.checkFOB.TabIndex = 3;
            this.checkFOB.Text = "FOB";
            this.checkFOB.UseVisualStyleBackColor = true;
            // 
            // checkHRAC
            // 
            this.checkHRAC.AutoSize = true;
            this.checkHRAC.Checked = true;
            this.checkHRAC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHRAC.Location = new System.Drawing.Point(61, 156);
            this.checkHRAC.Name = "checkHRAC";
            this.checkHRAC.Size = new System.Drawing.Size(56, 17);
            this.checkHRAC.TabIndex = 3;
            this.checkHRAC.Text = "HRAC";
            this.checkHRAC.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Nacionalidade";
            this.label4.Visible = false;
            // 
            // checkEstrangeiro
            // 
            this.checkEstrangeiro.AutoSize = true;
            this.checkEstrangeiro.Checked = true;
            this.checkEstrangeiro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEstrangeiro.Location = new System.Drawing.Point(308, 156);
            this.checkEstrangeiro.Name = "checkEstrangeiro";
            this.checkEstrangeiro.Size = new System.Drawing.Size(79, 17);
            this.checkEstrangeiro.TabIndex = 4;
            this.checkEstrangeiro.Text = "Estrangeiro";
            this.checkEstrangeiro.UseVisualStyleBackColor = true;
            this.checkEstrangeiro.Visible = false;
            // 
            // checkBrasileiro
            // 
            this.checkBrasileiro.AutoSize = true;
            this.checkBrasileiro.Checked = true;
            this.checkBrasileiro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBrasileiro.Location = new System.Drawing.Point(232, 156);
            this.checkBrasileiro.Name = "checkBrasileiro";
            this.checkBrasileiro.Size = new System.Drawing.Size(68, 17);
            this.checkBrasileiro.TabIndex = 4;
            this.checkBrasileiro.Text = "Brasileiro";
            this.checkBrasileiro.UseVisualStyleBackColor = true;
            this.checkBrasileiro.Visible = false;
            // 
            // checkExcluido
            // 
            this.checkExcluido.AutoSize = true;
            this.checkExcluido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkExcluido.Location = new System.Drawing.Point(453, 136);
            this.checkExcluido.Name = "checkExcluido";
            this.checkExcluido.Size = new System.Drawing.Size(165, 17);
            this.checkExcluido.TabIndex = 5;
            this.checkExcluido.Text = "Mostrar pacientes excluídos?";
            this.checkExcluido.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(547, 156);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 500);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 32);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(598, 500);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 32);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "&Sair";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblNenhum
            // 
            this.lblNenhum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNenhum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNenhum.Location = new System.Drawing.Point(201, 273);
            this.lblNenhum.Name = "lblNenhum";
            this.lblNenhum.Size = new System.Drawing.Size(280, 41);
            this.lblNenhum.TabIndex = 86;
            this.lblNenhum.Text = "Nenhum registro encontrado!";
            this.lblNenhum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNenhum.Visible = false;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPacientes.Location = new System.Drawing.Point(39, 185);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.ShowCellErrors = false;
            this.dgvPacientes.ShowEditingIcon = false;
            this.dgvPacientes.ShowRowErrors = false;
            this.dgvPacientes.Size = new System.Drawing.Size(579, 309);
            this.dgvPacientes.TabIndex = 87;
            this.dgvPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellDoubleClick);
            // 
            // ConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 544);
            this.Controls.Add(this.lblNenhum);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.checkEstrangeiro);
            this.Controls.Add(this.checkFOB);
            this.Controls.Add(this.checkBrasileiro);
            this.Controls.Add(this.checkHRAC);
            this.Controls.Add(this.checkCondicao);
            this.Controls.Add(this.checkNome);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.checkExcluido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsultaGeral";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaGeral";
            this.Load += new System.EventHandler(this.ConsultaGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkNome;
        private System.Windows.Forms.CheckBox checkCondicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkFOB;
        private System.Windows.Forms.CheckBox checkHRAC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkEstrangeiro;
        private System.Windows.Forms.CheckBox checkBrasileiro;
        private System.Windows.Forms.CheckBox checkExcluido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblNenhum;
        private System.Windows.Forms.DataGridView dgvPacientes;
    }
}