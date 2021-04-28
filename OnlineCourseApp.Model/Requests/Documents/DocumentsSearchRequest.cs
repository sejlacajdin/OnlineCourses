using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Documents
{
    public class DocumentsSearchRequest
    {
        [Required]
        public int CourseId { get; set; }
    }
}
