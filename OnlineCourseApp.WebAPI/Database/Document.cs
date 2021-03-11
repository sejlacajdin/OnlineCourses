using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class Document
    {
        public Document()
        {
            DocumentShares = new HashSet<DocumentShare>();
        }

        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public string FileExstension { get; set; }
        public DateTime UploadDate { get; set; }
        public string ContentType { get; set; }
        public int DocumentOwnerId { get; set; }
        public string FileOldName { get; set; }

        public virtual User DocumentOwner { get; set; }
        public virtual ICollection<DocumentShare> DocumentShares { get; set; }
    }
}
