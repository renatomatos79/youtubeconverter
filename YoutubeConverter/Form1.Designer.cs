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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDonwloadVideo = new System.Windows.Forms.Button();
            this.dlgMp4 = new System.Windows.Forms.OpenFileDialog();
            this.lblDownloading = new System.Windows.Forms.TextBox();
            this.dtgYoutube = new System.Windows.Forms.DataGridView();
            this.cbxYoutubeVideo = new System.Windows.Forms.ComboBox();
            this.ProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.OutputFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgYoutube)).BeginInit();
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
            // btnDonwloadVideo
            // 
            this.btnDonwloadVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonwloadVideo.Location = new System.Drawing.Point(758, 23);
            this.btnDonwloadVideo.Name = "btnDonwloadVideo";
            this.btnDonwloadVideo.Size = new System.Drawing.Size(122, 23);
            this.btnDonwloadVideo.TabIndex = 3;
            this.btnDonwloadVideo.Text = "Download";
            this.btnDonwloadVideo.UseVisualStyleBackColor = true;
            this.btnDonwloadVideo.Click += new System.EventHandler(this.btnDonwloadVideo_Click);
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
            // dtgYoutube
            // 
            this.dtgYoutube.AllowUserToAddRows = false;
            this.dtgYoutube.AllowUserToDeleteRows = false;
            this.dtgYoutube.AllowUserToResizeRows = false;
            this.dtgYoutube.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgYoutube.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgYoutube.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessId,
            this.StartedOn,
            this.Url,
            this.OutputFileName,
            this.Status,
            this.CompletedOn,
            this.Action});
            this.dtgYoutube.Location = new System.Drawing.Point(15, 53);
            this.dtgYoutube.Name = "dtgYoutube";
            this.dtgYoutube.ReadOnly = true;
            this.dtgYoutube.RowHeadersVisible = false;
            this.dtgYoutube.Size = new System.Drawing.Size(865, 192);
            this.dtgYoutube.TabIndex = 6;
            this.dtgYoutube.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgYoutube_CellContentClick);
            // 
            // cbxYoutubeVideo
            // 
            this.cbxYoutubeVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxYoutubeVideo.FormattingEnabled = true;
            this.cbxYoutubeVideo.Items.AddRange(new object[] {
            "https://www.youtube.com/watch?v=T-Mlrp5x2_M",
            "https://www.youtube.com/watch?v=k9JRuIO3cjk",
            "https://www.youtube.com/watch?v=X48VuDVv0do",
            "https://www.youtube.com/watch?v=b9Gb9v675YI"});
            this.cbxYoutubeVideo.Location = new System.Drawing.Point(15, 25);
            this.cbxYoutubeVideo.Name = "cbxYoutubeVideo";
            this.cbxYoutubeVideo.Size = new System.Drawing.Size(737, 21);
            this.cbxYoutubeVideo.TabIndex = 7;
            // 
            // ProcessId
            // 
            this.ProcessId.DataPropertyName = "ProcessId";
            this.ProcessId.HeaderText = "Process ID";
            this.ProcessId.Name = "ProcessId";
            this.ProcessId.ReadOnly = true;
            // 
            // StartedOn
            // 
            this.StartedOn.DataPropertyName = "StartedOn";
            this.StartedOn.HeaderText = "Start time";
            this.StartedOn.Name = "StartedOn";
            this.StartedOn.ReadOnly = true;
            this.StartedOn.Width = 125;
            // 
            // Url
            // 
            this.Url.DataPropertyName = "YoutubeUrl";
            this.Url.HeaderText = "Youtube url";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Width = 225;
            // 
            // OutputFileName
            // 
            this.OutputFileName.DataPropertyName = "OutputFileName";
            this.OutputFileName.HeaderText = "Output file";
            this.OutputFileName.Name = "OutputFileName";
            this.OutputFileName.ReadOnly = true;
            this.OutputFileName.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 50;
            // 
            // CompletedOn
            // 
            this.CompletedOn.DataPropertyName = "CompletedOn";
            this.CompletedOn.HeaderText = "End time";
            this.CompletedOn.Name = "CompletedOn";
            this.CompletedOn.ReadOnly = true;
            this.CompletedOn.Width = 125;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "ActionName";
            this.Action.HeaderText = "";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 253);
            this.Controls.Add(this.cbxYoutubeVideo);
            this.Controls.Add(this.dtgYoutube);
            this.Controls.Add(this.lblDownloading);
            this.Controls.Add(this.btnDonwloadVideo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Youtube Download";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgYoutube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDonwloadVideo;
        private System.Windows.Forms.OpenFileDialog dlgMp4;
        private System.Windows.Forms.TextBox lblDownloading;
        private System.Windows.Forms.DataGridView dtgYoutube;
        private System.Windows.Forms.ComboBox cbxYoutubeVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartedOn;
        private System.Windows.Forms.DataGridViewLinkColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletedOn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}

