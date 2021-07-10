using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.CourseParticipants
{
    public class CourseParticipantsInsertRequest
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Comment { get; set; }
        public int Review { get; set; }
        public DateTime ParticipationDate { get; set; }
    }
}
