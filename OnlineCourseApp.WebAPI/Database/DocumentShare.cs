using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class DocumentShare
    {
        public DocumentShare()
        {
            DocumentDownloadeds = new HashSet<DocumentDownloaded>();
        }

        public int DocumentShareId { get; set; }
        public int DocumentId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Document Document { get; set; }
        public virtual ICollection<DocumentDownloaded> DocumentDownloadeds { get; set; }
    }
}
