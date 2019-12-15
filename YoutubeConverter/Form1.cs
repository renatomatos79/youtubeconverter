using NReco.VideoConverter;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeConverter.Properties;
using YoutubeExplode;

namespace YoutubeConverter
{
    public partial class Form1 : Form
    {
        private YoutubeClient client = new YoutubeClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDownload.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var link = textBox1.Text;
                lblTitle.Tag = YoutubeClient.ParseVideoId(link);
                var playlist = client.GetPlaylistAsync(lblTitle.Tag.ToString()).Result;
                var video = playlist.Videos.First();
                lblTitle.Text = video.Title;                
            }
            catch 
            {
                lblTitle.Text = Guid.NewGuid().ToString();
            }
            finally
            {
                btnDownload.Visible = true;
            }
        }

        private void BtnDownload_Click_1(object sender, EventArgs e)
        {
            btnDownload.Enabled = false;
            try
            {
                var file = $@"C:\Temp\Download\{lblTitle.Text}.mp4";
                var streamInfoSet = client.GetVideoMediaStreamInfosAsync(lblTitle.Tag.ToString()).Result.Muxed.FirstOrDefault();
                // Download stream to file
                var download = client.DownloadMediaStreamAsync(streamInfoSet, file);
                while (!download.IsCompleted)
                {
                    System.Threading.Thread.Sleep(1000);
                }
                MessageBox.Show($"Download Complete {file}");
            }
            finally
            {
                btnDownload.Enabled = true;
                btnDownload.Visible = false;
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (dlgMp4.ShowDialog() == DialogResult.OK)
            {
                btnConvert.Enabled = false;
                try
                {
                    var output = Path.ChangeExtension(dlgMp4.FileName, "mp3");
                    ConvertToMp3(dlgMp4.FileName, output);
                    MessageBox.Show($"Complete!");
                }
                finally
                {
                    btnConvert.Enabled = true;
                }
            }
        }

        private void ConvertToMp3(string inputFile, string outputFile)
        {
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            ffMpeg.ConvertMedia(inputFile, outputFile, Format.mp4);
        }
    }
}
