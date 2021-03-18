using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class CourseParticipant
    {
        public int CourseParticipantId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Comment { get; set; }
        public int Review { get; set; }

        public virtual Course Course { get; set; }
        public virtual User Student { get; set; }
    }
}
