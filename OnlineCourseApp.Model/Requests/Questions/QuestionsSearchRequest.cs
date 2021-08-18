using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Questions
{
    public class QuestionsSearchRequest
    {
        public QuestionsSearchRequest()
        {
            IsActive = false;
        }
        public int ExamId { get; set; }
        public string Question { get; set; }
        public bool IsActive { get; set; }
    }
}
