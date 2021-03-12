using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class CourseSection
    {
        public CourseSection()
        {
            AnnouncementFilters = new HashSet<AnnouncementFilter>();
            Courses = new HashSet<Course>();
            InverseCourseParent = new HashSet<CourseSection>();
        }

        public int CourseSectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseTypeId { get; set; }
        public int? CourseParentId { get; set; }

        public virtual CourseSection CourseParent { get; set; }
        public virtual CourseType CourseType { get; set; }
        public virtual ICollection<AnnouncementFilter> AnnouncementFilters { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<CourseSection> InverseCourseParent { get; set; }
    }
}
