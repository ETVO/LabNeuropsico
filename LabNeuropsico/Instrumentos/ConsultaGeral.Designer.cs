namespace LabNeuropsico.Instrumentos
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
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnExcluirInstrumento = new System.Windows.Forms.Button();
            this.cmbTipoAval = new System.Windows.Forms.ComboBox();
            this.lblNenhum = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.checkExcluido = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvInstrumentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(39, 401);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(192, 40);
            this.btnVisualizar.TabIndex = 104;
            this.btnVisualizar.Text = "Visualizar selecionado";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnExcluirInstrumento
            // 
            this.btnExcluirInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirInstrumento.Location = new System.Drawing.Point(462, 401);
            this.btnExcluirInstrumento.Name = "btnExcluirInstrumento";
            this.btnExcluirInstrumento.Size = new System.Drawing.Size(156, 40);
            this.btnExcluirInstrumento.TabIndex = 103;
            this.btnExcluirInstrumento.Text = "Excluir selecionado";
            this.btnExcluirInstrumento.UseVisualStyleBackColor = true;
            this.btnExcluirInstrumento.Click += new System.EventHandler(this.btnExcluirInstrumento_Click);
            // 
            // cmbTipoAval
            // 
            this.cmbTipoAval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAval.FormattingEnabled = true;
            this.cmbTipoAval.Items.AddRange(new object[] {
            "Todas",
            "Intelectual",
            "Psicomotora",
            "Cognitiva",
            "Comportamental",
            "Executiva"});
            this.cmbTipoAval.Location = new System.Drawing.Point(246, 96);
            this.cmbTipoAval.Name = "cmbTipoAval";
            this.cmbTipoAval.Size = new System.Drawing.Size(192, 23);
            this.cmbTipoAval.TabIndex = 102;
            // 
            // lblNenhum
            // 
            this.lblNenhum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNenhum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNenhum.Location = new System.Drawing.Point(201, 217);
            this.lblNenhum.Name = "lblNenhum";
            this.lblNenhum.Size = new System.Drawing.Size(280, 41);
            this.lblNenhum.TabIndex = 100;
            this.lblNenhum.Text = "Nenhum registro encontrado!";
            this.lblNenhum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNenhum.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 451);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 32);
            this.btnVoltar.TabIndex = 94;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(598, 451);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 32);
            this.btnFechar.TabIndex = 95;
            this.btnFechar.Text = "&Sair";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(547, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 23);
            this.btnBuscar.TabIndex = 93;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // checkExcluido
            // 
            this.checkExcluido.AutoSize = true;
            this.checkExcluido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkExcluido.Location = new System.Drawing.Point(440, 76);
            this.checkExcluido.Name = "checkExcluido";
            this.checkExcluido.Size = new System.Drawing.Size(178, 17);
            this.checkExcluido.TabIndex = 92;
            this.checkExcluido.Text = "Mostrar instrumentos excluídos?";
            this.checkExcluido.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 99;
            this.label3.Text = "Tipo de Avaliação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 97;
            this.label1.Text = "Filtros:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(427, 31);
            this.label15.TabIndex = 96;
            this.label15.Text = "Consulta Geral de Instrumentos";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(39, 96);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(192, 23);
            this.txtBusca.TabIndex = 91;
            // 
            // dgvInstrumentos
            // 
            this.dgvInstrumentos.AllowUserToAddRows = false;
            this.dgvInstrumentos.AllowUserToDeleteRows = false;
            this.dgvInstrumentos.AllowUserToResizeRows = false;
            this.dgvInstrumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstrumentos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvInstrumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstrumentos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInstrumentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInstrumentos.Location = new System.Drawing.Point(39, 129);
            this.dgvInstrumentos.Name = "dgvInstrumentos";
            this.dgvInstrumentos.RowHeadersVisible = false;
            this.dgvInstrumentos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInstrumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstrumentos.ShowCellErrors = false;
            this.dgvInstrumentos.ShowEditingIcon = false;
            this.dgvInstrumentos.ShowRowErrors = false;
            this.dgvInstrumentos.Size = new System.Drawing.Size(579, 266);
            this.dgvInstrumentos.TabIndex = 101;
            this.dgvInstrumentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstrumentos_CellDoubleClick);
            this.dgvInstrumentos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstrumentos_RowEnter);
            // 
            // ConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 495);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnExcluirInstrumento);
            this.Controls.Add(this.cmbTipoAval);
            this.Controls.Add(this.lblNenhum);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.checkExcluido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvInstrumentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsultaGeral";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Geral";
            this.Load += new System.EventHandler(this.ConsultaGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExcluirInstrumento;
        private System.Windows.Forms.ComboBox cmbTipoAval;
        private System.Windows.Forms.Label lblNenhum;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox checkExcluido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvInstrumentos;
    }
}