using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class Video
    {
        public int VideoId { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public long? Size { get; set; }
        public byte[] File { get; set; }

        public virtual Course Course { get; set; }
    }
}
