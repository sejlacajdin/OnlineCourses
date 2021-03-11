using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class Question
    {
        public Question()
        {
            Choices = new HashSet<Choice>();
            ExamAnsweredQuestions = new HashSet<ExamAnsweredQuestion>();
        }

        public int QuestionId { get; set; }
        public int QuestionCategoryId { get; set; }
        public int QuestionTypeId { get; set; }
        public int ExamId { get; set; }
        public double Points { get; set; }
        public bool IsActive { get; set; }
        public string Text { get; set; }
        public int QuestionNumber { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual QuestionCategory QuestionCategory { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual ICollection<Choice> Choices { get; set; }
        public virtual ICollection<ExamAnsweredQuestion> ExamAnsweredQuestions { get; set; }
    }
}
