using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class Announcements
    {
        public int AnnouncementId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int AnnouncementOwnerId { get; set; }
        public int FilterTypeId { get; set; }
        public string PostOwner { get; set; }
    }
}
