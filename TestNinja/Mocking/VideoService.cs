using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        private IFileReader _fileReader;
        private IVideoRepository _videoRepository;

        public VideoService(IFileReader fileReader = null, IVideoRepository videoRepository = null) //to use with fakefilereader
        {
            _fileReader = fileReader ?? new FileReader(); //dependency injection by constructor
            _videoRepository = videoRepository ?? new VideoRepository();
        }
        public string ReadVideoTitle() 
        {
            //Dependency Injection can be use by parameters, by properties or my constructors

            //var str = File.ReadAllText("video.txt");
            var str = _fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        // [] => ""
        // [{},{},{}] => "1,2,3"
        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();
            var videos = _videoRepository.GetUnprodessedVideos();//loosely coupled                  
            
            foreach (var v in videos)
                videoIds.Add(v.Id);

            return String.Join(",", videoIds);
            //return "1";
            
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}