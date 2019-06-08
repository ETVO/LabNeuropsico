namespace LabNeuropsico
{
    partial class Master
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(54, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LabNeuropsico";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(57, 49);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(164, 17);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Inicializando banco de dados...";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loading
            // 
            this.loading.Image = global::LabNeuropsico.Properties.Resources.loading;
            this.loading.Location = new System.Drawing.Point(33, 7);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(209, 148);
            this.loading.TabIndex = 3;
            this.loading.TabStop = false;
            this.loading.WaitOnLoad = true;
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 159);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Master";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Master_Load);
            this.Click += new System.EventHandler(this.Master_Click);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Timer timer;
    }
}