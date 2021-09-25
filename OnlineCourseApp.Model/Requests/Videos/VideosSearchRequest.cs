using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Videos
{
    public class VideosSearchRequest
    {
        [Required]
        public int CourseId { get; set; }
        public string Name { get; set; }
    }
}
