namespace YoutubeConverter
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDonwloadVideo = new System.Windows.Forms.Button();
            this.dlgMp4 = new System.Windows.Forms.OpenFileDialog();
            this.lblDownloading = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video Url";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnDonwloadVideo
            // 
            this.btnDonwloadVideo.Location = new System.Drawing.Point(545, 25);
            this.btnDonwloadVideo.Name = "btnDonwloadVideo";
            this.btnDonwloadVideo.Size = new System.Drawing.Size(122, 23);
            this.btnDonwloadVideo.TabIndex = 3;
            this.btnDonwloadVideo.Text = "Download";
            this.btnDonwloadVideo.UseVisualStyleBackColor = true;
            this.btnDonwloadVideo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dlgMp4
            // 
            this.dlgMp4.FileName = "openFileDialog1";
            // 
            // lblDownloading
            // 
            this.lblDownloading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDownloading.Location = new System.Drawing.Point(15, 61);
            this.lblDownloading.Name = "lblDownloading";
            this.lblDownloading.ReadOnly = true;
            this.lblDownloading.Size = new System.Drawing.Size(653, 13);
            this.lblDownloading.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(273, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 122);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDownloading);
            this.Controls.Add(this.btnDonwloadVideo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Youtube Download";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDonwloadVideo;
        private System.Windows.Forms.OpenFileDialog dlgMp4;
        private System.Windows.Forms.TextBox lblDownloading;
        private System.Windows.Forms.Button btnCancel;
    }
}

