using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Questions
{
    public class QuestionsSearchRequest
    {
        public int ExamId { get; set; }
        public string Question { get; set; }
    }
}
