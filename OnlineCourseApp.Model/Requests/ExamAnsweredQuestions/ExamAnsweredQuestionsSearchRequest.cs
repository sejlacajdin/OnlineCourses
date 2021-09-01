using System;
using System.Collections.Generic;

namespace OnlineCourseApp.Model
{
    public class ExamAnsweredQuestionsSearchRequest
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public int ChoiceId { get; set; }
        public int QuestionId { get; set; }
    }
}
