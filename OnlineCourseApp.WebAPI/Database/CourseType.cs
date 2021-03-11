using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class CourseType
    {
        public CourseType()
        {
            CourseSections = new HashSet<CourseSection>();
        }

        public int CourseTypeId { get; set; }
        public string Name { get; set; }
        public DateTime RecordUpdated { get; set; }

        public virtual ICollection<CourseSection> CourseSections { get; set; }
    }
}
