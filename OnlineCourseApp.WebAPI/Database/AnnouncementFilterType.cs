using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class AnnouncementFilterType
    {
        public AnnouncementFilterType()
        {
            Announcements = new HashSet<Announcement>();
        }

        public int AnnouncementFilterTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
