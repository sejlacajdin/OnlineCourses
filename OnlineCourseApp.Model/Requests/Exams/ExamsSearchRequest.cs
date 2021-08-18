using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Exams
{
    public class ExamsSearchRequest
    {
        public ExamsSearchRequest()
        {
            IsActive = false;
        }
        public string Title { get; set; }
        public int ExamOwnerId { get; set; }
        public int CourseId { get; set; }
        public bool IsActive { get; set; }
    }
}
