using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class Documents
    {
        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public string FileExstension { get; set; }
        public DateTime UploadDate { get; set; }
        public string ContentType { get; set; }
        public string FileOldName { get; set; }
        public string Path { get; set; }
    }
}
