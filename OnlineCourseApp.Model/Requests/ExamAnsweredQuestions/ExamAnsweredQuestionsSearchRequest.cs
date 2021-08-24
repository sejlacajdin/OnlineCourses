using System;
using System.Collections.Generic;

namespace OnlineCourseApp.Model
{
    public class ExamAnsweredQuestionsSearchRequest
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
    }
}
