using System;

namespace OnlineCourseApp.Model
{
    public class CourseSections
    {
        public int CourseSectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseTypeId { get; set; }
        public int? CourseParentId { get; set; }
    }
}
