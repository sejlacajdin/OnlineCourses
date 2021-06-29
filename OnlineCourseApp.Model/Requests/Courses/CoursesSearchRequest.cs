using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Courses
{
    public class CoursesSearchRequest
    {
        public string CourseName { get; set; }
        public int ProfessorId { get; set; }

    }
}
