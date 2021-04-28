using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class DocumentsShare
    {
        public int DocumentShareId { get; set; }
        public int DocumentId { get; set; }
        public int CourseId { get; set; }
    }
}
