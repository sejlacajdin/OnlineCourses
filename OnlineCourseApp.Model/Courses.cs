using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class Courses
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Notes { get; set; }
        public int ProfessorId { get; set; }
        public bool IsActive { get; set; }
        public int CourseSectionId { get; set; }
    }
}
