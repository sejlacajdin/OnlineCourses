using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.ExamAnsweredQuestions
{
    public class ExamAnsweredQuestionsInsertRequest
    {
        public int StudentId { get; set; }
        public int QuestionId { get; set; }
        public int ChoiceId { get; set; }
        public string Answer { get; set; }
        public double MarkScored { get; set; }
    }
}
