namespace LabNeuropsico
{
    partial class Index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnInstrumentos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opções";
            // 
            // btnPacientes
            // 
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Location = new System.Drawing.Point(19, 81);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(166, 41);
            this.btnPacientes.TabIndex = 1;
            this.btnPacientes.Text = "&Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnInstrumentos
            // 
            this.btnInstrumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstrumentos.Location = new System.Drawing.Point(19, 128);
            this.btnInstrumentos.Name = "btnInstrumentos";
            this.btnInstrumentos.Size = new System.Drawing.Size(166, 41);
            this.btnInstrumentos.TabIndex = 3;
            this.btnInstrumentos.Text = "&Instrumentos";
            this.btnInstrumentos.UseVisualStyleBackColor = true;
            this.btnInstrumentos.Click += new System.EventHandler(this.btnInstrumentos_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(19, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "&Usuários";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(483, 406);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 32);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "&Sair";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(19, 222);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(166, 41);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.Text = "&Configurações";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Location = new System.Drawing.Point(19, 269);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(166, 41);
            this.btnSobre.TabIndex = 6;
            this.btnSobre.Text = "&Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnInstrumentos);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnInstrumentos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnSobre;
    }
}

