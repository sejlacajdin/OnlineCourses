using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Videos
{
    public class VideosInsertRequest
    {
        [Required]
        public int CourseId { get; set; }
        [Required]
        public string Name { get; set; }
        public long? Size { get; set; }
        [Required]
        public byte[] File { get; set; }
    }
}
