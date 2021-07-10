using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.CourseParticipants
{
    public class CourseParticipantsSearchRequest
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
