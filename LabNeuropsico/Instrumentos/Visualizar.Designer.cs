namespace LabNeuropsico.Instrumentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluirInstrumento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNenhum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(305, 31);
            this.label15.TabIndex = 97;
            this.label15.Text = "Visualizar Instrumento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblNenhum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvCampos);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 301);
            this.panel1.TabIndex = 100;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 32);
            this.btnVoltar.TabIndex = 104;
            this.btnVoltar.Text = "&Cancelar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluirInstrumento
            // 
            this.btnExcluirInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirInstrumento.Location = new System.Drawing.Point(209, 374);
            this.btnExcluirInstrumento.Name = "btnExcluirInstrumento";
            this.btnExcluirInstrumento.Size = new System.Drawing.Size(156, 40);
            this.btnExcluirInstrumento.TabIndex = 105;
            this.btnExcluirInstrumento.Text = "Excluir instrumento";
            this.btnExcluirInstrumento.UseVisualStyleBackColor = true;
            this.btnExcluirInstrumento.Click += new System.EventHandler(this.btnExcluirInstrumento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 109;
            this.label2.Text = "Campos";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCampos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCampos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCampos.Location = new System.Drawing.Point(48, 113);
            this.dgvCampos.MultiSelect = false;
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.RowHeadersVisible = false;
            this.dgvCampos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCampos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCampos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCampos.ShowCellErrors = false;
            this.dgvCampos.ShowEditingIcon = false;
            this.dgvCampos.ShowRowErrors = false;
            this.dgvCampos.Size = new System.Drawing.Size(260, 171);
            this.dgvCampos.TabIndex = 108;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(45, 68);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(134, 17);
            this.lblTipo.TabIndex = 107;
            this.lblTipo.Text = "Tipo do Instrumento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 106;
            this.label3.Text = "Tipo de avaliação";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.Control;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(45, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(143, 17);
            this.lblNome.TabIndex = 105;
            this.lblNome.Text = "Nome do Instrumento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 104;
            this.label1.Text = "Nome";
            // 
            // lblNenhum
            // 
            this.lblNenhum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNenhum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNenhum.Location = new System.Drawing.Point(61, 174);
            this.lblNenhum.Name = "lblNenhum";
            this.lblNenhum.Size = new System.Drawing.Size(233, 40);
            this.lblNenhum.TabIndex = 106;
            this.lblNenhum.Text = "Nenhum campo encontrado!";
            this.lblNenhum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNenhum.Visible = false;
            // 
            // Visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 449);
            this.Controls.Add(this.btnExcluirInstrumento);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Visualizar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar";
            this.Load += new System.EventHandler(this.Visualizar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCampos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirInstrumento;
        private System.Windows.Forms.Label lblNenhum;
    }
}