using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Proxy
{
    public interface IThirdPartyYouTubeLib
    {
        List<string> ListVideos();
        string GetVideoInfo(string videoId);
        void DownloadVideo(string videoId);
    }

    public class ThirdPartyYouTubeClass : IThirdPartyYouTubeLib
    {
        public List<string> ListVideos()
        {
            Console.WriteLine("Fetching video list from YouTube...");
            SimulateNetworkLatency();
            return new List<string> { "Video1", "Video2", "Video3" };
        }

        public string GetVideoInfo(string videoId)
        {
            Console.WriteLine($"Fetching info for video: {videoId}");
            SimulateNetworkLatency();
            return $"Info for {videoId}";
        }

        public void DownloadVideo(string videoId)
        {
            Console.WriteLine($"Downloading video: {videoId}");
            SimulateNetworkLatency();
        }

        private void SimulateNetworkLatency()
        {
            Console.WriteLine($"Executing Request");
            System.Threading.Thread.Sleep(2000); // 2 seconds delay
        }
    }

    // Proxy class that adds caching functionality
    public class CachedYouTubeClass : IThirdPartyYouTubeLib
    {
        private readonly IThirdPartyYouTubeLib _service;
        private List<string> _listCache;
        private Dictionary<string, string> _videoCache = new Dictionary<string, string>();

        private bool _needReset;

        //inject service 
        public CachedYouTubeClass(IThirdPartyYouTubeLib service)
        {
            _service = service;
        }

        public List<string> ListVideos()
        {
            if (_listCache == null || _needReset)
            {
                Console.WriteLine("Cache miss: Fetching video list from service.");
                _listCache = _service.ListVideos();
            }
            else
            {
                Console.WriteLine("Cache hit: Returning cached video list.");
            }
            return _listCache;
        }

        public string GetVideoInfo(string videoId)
        {
            if (!_videoCache.ContainsKey(videoId) || _needReset)
            {
                Console.WriteLine($"Cache miss: Fetching info for video: {videoId}");
                _videoCache[videoId] = _service.GetVideoInfo(videoId);
            }
            else
            {
                Console.WriteLine($"Cache hit: Returning cached info for video: {videoId}");
            }
            return _videoCache[videoId];
        }


        public void DownloadVideo(string videoId)
        {
            Console.WriteLine($"Downloading video: {videoId}");
            _service.DownloadVideo(videoId);
        }
        public void ResetCache()
        {
            _needReset = true;
            _listCache = null;
            _videoCache.Clear();
            Console.WriteLine("Cache has been reset.");
        }

    }

    //client class for youtube service
    public class YouTubeManager
    {

        private readonly IThirdPartyYouTubeLib _service;

        public YouTubeManager(IThirdPartyYouTubeLib service)
        {
            _service = service;
        }
        public void RenderVideoPage(string videoId)
        {
            string videoInfo = _service.GetVideoInfo(videoId);
            Console.WriteLine($"Rendering video page with info: {videoInfo}");
        }

        public void RenderListPanel()
        {
            var videoList = _service.ListVideos();
            Console.WriteLine("Rendering list panel with videos:");
            foreach (var video in videoList)
            {
                Console.WriteLine($"- {video}");
            }
        }

        public void ReactOnUserInput()
        {
            RenderVideoPage("Video1");
            RenderListPanel();
        }
    }


}
