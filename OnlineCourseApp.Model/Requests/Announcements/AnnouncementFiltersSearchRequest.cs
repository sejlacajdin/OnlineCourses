using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Announcements
{
    public class AnnouncementFiltersSearchRequest
    {
        public int AnnouncementId { get; set; }
        public int CourseTypeId { get; set; }
        public int CourseSectionId { get; set; }
        public int CourseId { get; set; }
    }
}
