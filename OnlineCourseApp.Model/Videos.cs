using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class Videos
    {
        public int VideoId { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public long? Size { get; set; }
        public byte[] File { get; set; }
    }
}
