using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Documents
{
    public class DocumentsInsertRequest
    {
       [Required]
        public string FileName { get; set; }
        [Required]
        public string FileExstension { get; set; }
        public DateTime? UploadDate { get; set; }
        [Required]
        public string ContentType { get; set; }
        [Required]
        public string FileOldName { get; set; }
        public string Path { get; set; }
    }
}
