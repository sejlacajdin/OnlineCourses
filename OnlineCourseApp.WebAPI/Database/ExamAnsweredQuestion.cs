using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class ExamAnsweredQuestion
    {
        public int ExamAnsweredQuestionId { get; set; }
        public int StudentId { get; set; }
        public int QuestionId { get; set; }
        public int ChoiceId { get; set; }
        public string Answer { get; set; }
        public double MarkScored { get; set; }

        public virtual Choice Choice { get; set; }
        public virtual Question Question { get; set; }
        public virtual User Student { get; set; }
    }
}
