using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeConverter.Factory;

namespace YoutubeConverter
{
    public partial class Form1 : Form
    {
        private List<DownloadTask> rows = new List<DownloadTask>();
        static readonly object lockControl = new object();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDownloading.Visible = true;
            //btnCancel.Visible = false;
            Label.CheckForIllegalCrossThreadCalls = false;
            Button.CheckForIllegalCrossThreadCalls = false;

            SetupGrid();
        }

        private void SetupGrid()
        {
            rows.Clear();

            dtgYoutube.AutoGenerateColumns = false;
            dtgYoutube.ReadOnly = true;
            dtgYoutube.DataSource = rows.ToList();
            dtgYoutube.Refresh();

            DataGridView.CheckForIllegalCrossThreadCalls = false;
        }

        private void RefreshGrid()
        {
            lock (lockControl)
            {
                try
                {
                    dtgYoutube.DataSource = rows.ToList();
                    dtgYoutube.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }        

        private void btnDonwloadVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbxYoutubeVideo.Text))
                {
                    MessageBox.Show("Please type a valid Youtube Url");
                    return;
                }

                var cancellationTokenSource = new CancellationTokenSource();
                var downloadTask = DownloadFactory.Create(cbxYoutubeVideo.Text, cancellationTokenSource);
                DownloadFactory.Download(downloadTask).ContinueWith((tk)=> 
                {
                    if (tk != null && tk.Status == TaskStatus.RanToCompletion)
                    {
                        tk.Result.Complete();
                    }
                    //RefreshGrid();
                });
                rows.Add(downloadTask);
                RefreshGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading file! {ex}");
            }
        }

        private void dtgYoutube_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    var task = dtgYoutube.Rows[e.RowIndex].DataBoundItem as DownloadTask;
                    if (task.CanCancel)
                    {
                        task.Cancel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
