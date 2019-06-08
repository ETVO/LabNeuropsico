namespace LabNeuropsico.Pacientes.Relatorios.Avaliacoes
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTipoLegenda = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNenhum = new System.Windows.Forms.Label();
            this.cmbInstrumento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(247, 80);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(219, 23);
            this.lblTipo.TabIndex = 108;
            this.lblTipo.Text = "Tipo de avaliação";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTipoLegenda
            // 
            this.lblTipoLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoLegenda.Location = new System.Drawing.Point(250, 60);
            this.lblTipoLegenda.Name = "lblTipoLegenda";
            this.lblTipoLegenda.Size = new System.Drawing.Size(215, 17);
            this.lblTipoLegenda.TabIndex = 109;
            this.lblTipoLegenda.Text = "Tipo de avaliação:";
            this.lblTipoLegenda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(393, 432);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 32);
            this.btnFechar.TabIndex = 107;
            this.btnFechar.Text = "&Sair";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 432);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 32);
            this.btnVoltar.TabIndex = 106;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(18, 379);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(155, 40);
            this.btnSalvar.TabIndex = 104;
            this.btnSalvar.Text = "&Salvar alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(179, 379);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 40);
            this.btnCancelar.TabIndex = 105;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNenhum
            // 
            this.lblNenhum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNenhum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNenhum.Location = new System.Drawing.Point(99, 215);
            this.lblNenhum.Name = "lblNenhum";
            this.lblNenhum.Size = new System.Drawing.Size(285, 41);
            this.lblNenhum.TabIndex = 103;
            this.lblNenhum.Text = "Nenhum instrumento selecionado!";
            this.lblNenhum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNenhum.Visible = false;
            // 
            // cmbInstrumento
            // 
            this.cmbInstrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInstrumento.FormattingEnabled = true;
            this.cmbInstrumento.Location = new System.Drawing.Point(18, 80);
            this.cmbInstrumento.Name = "cmbInstrumento";
            this.cmbInstrumento.Size = new System.Drawing.Size(212, 23);
            this.cmbInstrumento.TabIndex = 99;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(277, 31);
            this.label15.TabIndex = 102;
            this.label15.Text = "Visualizar Avaliação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "Instrumento utilizado";
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
            this.dgvCampos.Location = new System.Drawing.Point(17, 109);
            this.dgvCampos.MultiSelect = false;
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.RowHeadersVisible = false;
            this.dgvCampos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCampos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCampos.ShowCellErrors = false;
            this.dgvCampos.ShowEditingIcon = false;
            this.dgvCampos.ShowRowErrors = false;
            this.dgvCampos.Size = new System.Drawing.Size(448, 264);
            this.dgvCampos.TabIndex = 110;
            // 
            // Visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 474);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTipoLegenda);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNenhum);
            this.Controls.Add(this.cmbInstrumento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Visualizar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Avaliação";
            this.Load += new System.EventHandler(this.Visualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTipoLegenda;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNenhum;
        private System.Windows.Forms.ComboBox cmbInstrumento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCampos;
    }
}