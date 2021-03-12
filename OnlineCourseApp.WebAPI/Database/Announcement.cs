using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class Announcement
    {
        public Announcement()
        {
            AnnouncementFilters = new HashSet<AnnouncementFilter>();
        }

        public int AnnouncementId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int AnnouncementOwnerId { get; set; }
        public int FilterTypeId { get; set; }
        public string PostOwner { get; set; }

        public virtual User AnnouncementOwner { get; set; }
        public virtual AnnouncementFilterType FilterType { get; set; }
        public virtual ICollection<AnnouncementFilter> AnnouncementFilters { get; set; }
    }
}
