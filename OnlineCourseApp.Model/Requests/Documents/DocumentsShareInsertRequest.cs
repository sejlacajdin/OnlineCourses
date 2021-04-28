using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Documents
{
    public class DocumentsShareInsertRequest
    {
        public int DocumentId { get; set; }
        public int CourseId { get; set; }
    }
}
