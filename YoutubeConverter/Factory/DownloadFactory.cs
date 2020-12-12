using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeConverter.Factory
{
    public static class DownloadFactory
    {
        public static IEnumerable<IVideoStreamInfo> GetStreamFomVideoOption(this StreamManifest streamManifest, VideoOption videoOption)
        {
            if (videoOption == VideoOption.Video)
            {
                return streamManifest.GetVideo();
            }
            return streamManifest.GetVideoOnly();
        }

        private static string GetFileName()
        {
            var downloadFolder = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Downloads");
            if (!System.IO.Directory.Exists(downloadFolder))
            {
                System.IO.Directory.CreateDirectory(downloadFolder);
            }
            return System.IO.Path.Combine(downloadFolder, $"{Guid.NewGuid()}.mp4");
        }

        public static DownloadTask Create(string youtubeUrl, VideoOption videoOption, CancellationTokenSource cancellationTokenSource)
        {
            return new DownloadTask() 
            {
                OutputFileName = GetFileName(),
                YoutubeUrl = youtubeUrl,
                Option = videoOption,
                StartedOn = DateTime.Now,
                CancellationToken = cancellationTokenSource
            };
        }

        public static Task<DownloadTask> Download(DownloadTask downloadTask)
        {
            return Task.Run(async () =>
            {
                var youtube = new YoutubeClient();
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(downloadTask.YoutubeUrl);
                var streamInfo = streamManifest.GetStreamFomVideoOption(downloadTask.Option);
                var streamInfoSet = streamInfo.Where(s => s.Container == YoutubeExplode.Videos.Streams.Container.Mp4);
                var videoStreaming = streamInfoSet.WithHighestVideoQuality();

                await youtube.Videos.Streams.DownloadAsync(videoStreaming, downloadTask.OutputFileName, cancellationToken: downloadTask.CancellationToken.Token);
                
                return downloadTask;
            }, downloadTask.CancellationToken.Token);
        }
    }
}
