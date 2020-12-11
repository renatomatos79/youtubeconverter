using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeConverter
{
    public partial class Form1 : Form
    {
        private YoutubeClient client = new YoutubeClient();
        private CancellationTokenSource cancellationToken;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "https://www.youtube.com/watch?v=X48VuDVv0do";
            lblDownloading.Visible = true;
            btnCancel.Visible = false;
            Label.CheckForIllegalCrossThreadCalls = false;
            Button.CheckForIllegalCrossThreadCalls = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            btnDonwloadVideo.Enabled = false;
            btnDonwloadVideo.Text = "Downloading...";
            lblDownloading.Visible = false;
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please type a valid Youtube Url");
                    return;
                }

                btnCancel.Visible = true;

                var youtubeFile = textBox1.Text;
                var youtube = new YoutubeClient();

                cancellationToken = new CancellationTokenSource();

                Task.Run( async () =>
                {

                    return (await youtube.Videos.Streams.GetManifestAsync(youtubeFile))
                        .GetVideoOnly()
                        .Where(s => s.Container == YoutubeExplode.Videos.Streams.Container.Mp4)
                        .WithHighestVideoQuality();

                }, cancellationToken.Token).ContinueWith((taskStramInfoVideo) =>
                {
                    var stramInfoVideo = taskStramInfoVideo.Result;

                    lblDownloading.Text = $"Downloading file using {stramInfoVideo.Container} format ...";
                    lblDownloading.Visible = true;

                    var downloadFolder = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Downloads");
                    if (!System.IO.Directory.Exists(downloadFolder))
                    {
                        System.IO.Directory.CreateDirectory(downloadFolder);
                    }
                    var file = System.IO.Path.Combine(downloadFolder, $"{Guid.NewGuid()}.{stramInfoVideo.Container}");

                    youtube.Videos.Streams.DownloadAsync(stramInfoVideo, file).Wait();

                    return file;
                }, cancellationToken.Token).ContinueWith((file) => 
                {
                    if (file.Status == TaskStatus.RanToCompletion)
                    {
                        lblDownloading.Text = $"Download! {file.Result}";
                        btnDonwloadVideo.Enabled = true;
                    }                   
                });
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading file! {ex}");
                btnCancel.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancellationToken.Cancel();
            btnCancel.Visible = false;
            btnDonwloadVideo.Enabled = true;
            lblDownloading.Visible = true;
            lblDownloading.Text = "Download was canceled";
            btnDonwloadVideo.Text = "Download";
        }
    }
}
