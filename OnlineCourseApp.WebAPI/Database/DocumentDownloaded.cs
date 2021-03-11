using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class DocumentDownloaded
    {
        public int DocumentDownloadedId { get; set; }
        public int DocumentShareId { get; set; }
        public int StudentId { get; set; }

        public virtual DocumentShare DocumentShare { get; set; }
        public virtual User Student { get; set; }
    }
}
