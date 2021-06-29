using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class Exams
    {
        public int ExamId { get; set; }
        public string Title { get; set; }
        public string Instructions { get; set; }
        public string TimeLimit { get; set; }
        public bool IsActive { get; set; }
        public int CourseId { get; set; }
        public int ExamOwnerId { get; set; }
    }
}
