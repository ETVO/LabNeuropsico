namespace LabNeuropsico.Pacientes.Relatorios.Avaliacoes
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
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbInstrumento = new System.Windows.Forms.ComboBox();
            this.lblNenhum = new System.Windows.Forms.Label();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblTipoLegenda = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.linkAjuda = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(278, 31);
            this.label15.TabIndex = 89;
            this.label15.Text = "Cadastrar Avaliação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Selecione o instrumento utilizado";
            // 
            // cmbInstrumento
            // 
            this.cmbInstrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInstrumento.FormattingEnabled = true;
            this.cmbInstrumento.Location = new System.Drawing.Point(18, 78);
            this.cmbInstrumento.Name = "cmbInstrumento";
            this.cmbInstrumento.Size = new System.Drawing.Size(212, 23);
            this.cmbInstrumento.TabIndex = 1;
            this.cmbInstrumento.SelectedIndexChanged += new System.EventHandler(this.cmbInstrumento_SelectedIndexChanged);
            // 
            // lblNenhum
            // 
            this.lblNenhum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNenhum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNenhum.Location = new System.Drawing.Point(99, 213);
            this.lblNenhum.Name = "lblNenhum";
            this.lblNenhum.Size = new System.Drawing.Size(285, 41);
            this.lblNenhum.TabIndex = 91;
            this.lblNenhum.Text = "Nenhum instrumento selecionado!";
            this.lblNenhum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNenhum.Visible = false;
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
            this.dgvCampos.Location = new System.Drawing.Point(17, 107);
            this.dgvCampos.MultiSelect = false;
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.RowHeadersVisible = false;
            this.dgvCampos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCampos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCampos.ShowCellErrors = false;
            this.dgvCampos.ShowEditingIcon = false;
            this.dgvCampos.ShowRowErrors = false;
            this.dgvCampos.Size = new System.Drawing.Size(448, 264);
            this.dgvCampos.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(393, 430);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 32);
            this.btnFechar.TabIndex = 95;
            this.btnFechar.Text = "&Sair";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 430);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 32);
            this.btnVoltar.TabIndex = 94;
            this.btnVoltar.Text = "&Cancelar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(18, 377);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 40);
            this.btnSalvar.TabIndex = 92;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(136, 377);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 40);
            this.btnNovo.TabIndex = 93;
            this.btnNovo.Text = "&Limpar";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblTipoLegenda
            // 
            this.lblTipoLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoLegenda.Location = new System.Drawing.Point(250, 58);
            this.lblTipoLegenda.Name = "lblTipoLegenda";
            this.lblTipoLegenda.Size = new System.Drawing.Size(215, 17);
            this.lblTipoLegenda.TabIndex = 97;
            this.lblTipoLegenda.Text = "Tipo de avaliação:";
            this.lblTipoLegenda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(247, 78);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(219, 23);
            this.lblTipo.TabIndex = 97;
            this.lblTipo.Text = "Tipo de avaliação";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // linkAjuda
            // 
            this.linkAjuda.AutoSize = true;
            this.linkAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAjuda.Location = new System.Drawing.Point(427, 374);
            this.linkAjuda.Name = "linkAjuda";
            this.linkAjuda.Size = new System.Drawing.Size(38, 15);
            this.linkAjuda.TabIndex = 98;
            this.linkAjuda.TabStop = true;
            this.linkAjuda.Text = "Ajuda";
            this.linkAjuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAjuda_LinkClicked);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 474);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTipoLegenda);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblNenhum);
            this.Controls.Add(this.dgvCampos);
            this.Controls.Add(this.cmbInstrumento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Avaliação";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInstrumento;
        private System.Windows.Forms.Label lblNenhum;
        private System.Windows.Forms.DataGridView dgvCampos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblTipoLegenda;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.LinkLabel linkAjuda;
    }
}