using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace OnlineCourseApp.Model.Requests.Documents
{
    public class FileInsert
    {
        [Required]
        public IFormFile File { get; set; }
    }
}
