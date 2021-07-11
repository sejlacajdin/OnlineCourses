using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Documents
{
    public class DocumentsDownloadedInsertRequest
    {
        public int DocumentId { get; set; }
        public int StudentId { get; set; }
    }
}
