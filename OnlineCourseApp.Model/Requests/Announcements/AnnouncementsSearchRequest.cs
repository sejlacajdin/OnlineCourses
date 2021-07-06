using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Announcements
{
    public class AnnouncementsSearchRequest
    {
        public string Title { get; set; }
        public int AnnouncementOwnerId { get; set; }
        public List<int> FilterTypeId { get; set; }
    }
}
