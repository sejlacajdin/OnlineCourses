using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class Choice
    {
        public Choice()
        {
            ExamAnsweredQuestions = new HashSet<ExamAnsweredQuestion>();
        }

        public int ChoiceId { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public double Percentage { get; set; }
        public bool? IsCorrect { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<ExamAnsweredQuestion> ExamAnsweredQuestions { get; set; }
    }
}
