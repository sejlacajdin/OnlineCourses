using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class Exam
    {
        public Exam()
        {
            Questions = new HashSet<Question>();
        }

        public int ExamId { get; set; }
        public string Title { get; set; }
        public string Instructions { get; set; }
        public TimeSpan TimeLimit { get; set; }
        public bool IsActive { get; set; }
        public int CourseId { get; set; }
        public int ExamOwnerId { get; set; }

        public virtual Course Course { get; set; }
        public virtual User ExamOwner { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
