using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Courses
{
    public class CoursesSearchRequest
    {
        public CoursesSearchRequest()
        {
            IsActive = false;
        }
        public string CourseName { get; set; }
        public int ProfessorId { get; set; }
        public bool IsActive { get; set; }
        public int CourseSectionId { get; set; }

    }
}
