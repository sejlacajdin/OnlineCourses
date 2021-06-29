using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Exams
{
    public class ExamsSearchRequest
    {
        public string Title { get; set; }
        public int ExamOwnerId { get; set; }

    }
}
