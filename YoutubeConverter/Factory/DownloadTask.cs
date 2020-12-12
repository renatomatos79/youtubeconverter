using System;
using System.Threading;
using System.Threading.Tasks;

namespace YoutubeConverter.Factory
{
    public class DownloadTask
    {
        public DownloadTask()
        {
            this.CanCancel = true;
            this.Completed = false;
            this.ProcessId = Guid.NewGuid().ToString();
            this.Status = "Downloading";
        }

        public string ProcessId { get; }
        public string YoutubeUrl { get; set; }
        public string OutputFileName { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public string Status { get; internal set; }
        public string ActionName 
        {
            get
            {
                return CanCancel ? "Cancel" : string.Empty;
            }
        }
        public bool CanCancel { get; internal set; }
        public bool Completed { get; internal set; }
        public CancellationTokenSource CancellationToken { get; set; }
        public void Complete()
        {
            this.CompletedOn = DateTime.Now;
            this.CanCancel = false;
            this.Completed = true;
            this.Status = "Completed";
        }
        public void Cancel()
        {
            this.CompletedOn = null;
            this.CanCancel = false;
            this.Completed = false;
            this.Status = "Canceled";
            CancellationToken.Cancel();
        }
    }
}
