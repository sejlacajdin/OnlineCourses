using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class AnnouncementFilter
    {
        public int AnnouncementFilterId { get; set; }
        public int AnnouncementId { get; set; }
        public int? CourseTypeId { get; set; }
        public int? CourseSectionId { get; set; }
        public int? CourseId { get; set; }

        public virtual Announcement Announcement { get; set; }
        public virtual Course Course { get; set; }
        public virtual CourseSection CourseSection { get; set; }
        public virtual CourseType CourseType { get; set; }
    }
}
