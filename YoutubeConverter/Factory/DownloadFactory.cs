using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeConverter.Factory
{
    public static class DownloadFactory
    {
        private static string GetFileName()
        {
            var downloadFolder = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Downloads");
            if (!System.IO.Directory.Exists(downloadFolder))
            {
                System.IO.Directory.CreateDirectory(downloadFolder);
            }
            return System.IO.Path.Combine(downloadFolder, $"{Guid.NewGuid()}.mp4");
        }

        public static DownloadTask Create(string youtubeUrl, CancellationTokenSource cancellationTokenSource)
        {
            return new DownloadTask() 
            {
                OutputFileName = GetFileName(),
                YoutubeUrl = youtubeUrl,
                StartedOn = DateTime.Now,
                CancellationToken = cancellationTokenSource
            };
        }

        public static Task<DownloadTask> Download(DownloadTask downloadTask)
        {
            return Task.Run(async () =>
            {
                var task = Create(downloadTask.YoutubeUrl, downloadTask.CancellationToken);
                var youtube = new YoutubeClient();
                var taskStramInfoVideo = (await youtube.Videos.Streams.GetManifestAsync(downloadTask.YoutubeUrl))
                .GetVideoOnly()
                .Where(s => s.Container == Container.Mp4)
                .WithHighestVideoQuality();

                await youtube.Videos.Streams.DownloadAsync(taskStramInfoVideo, task.OutputFileName, cancellationToken: downloadTask.CancellationToken.Token);
                
                return downloadTask;
            }, downloadTask.CancellationToken.Token);
        }
    }
}
