using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public interface IVideoRepository
    {
        IEnumerable<Video> GetUnprodessedVideos();
    }

    public class VideoRepository : IVideoRepository
    {
        public IEnumerable<Video> GetUnprodessedVideos()
        {
            using (var context = new VideoContext())
            {
                var videos =
                (from video in context.Videos
                 where !video.IsProcessed
                 select video).ToList(); //external resource

                return videos;
            }
        }
    }
}
