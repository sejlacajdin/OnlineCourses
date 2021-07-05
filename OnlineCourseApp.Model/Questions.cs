using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class Questions
    {
        public int QuestionId { get; set; }
        public int QuestionCategoryId { get; set; }
        public int QuestionTypeId { get; set; }
        public int ExamId { get; set; }
        public double Points { get; set; }
        public bool IsActive { get; set; }
        public string Text { get; set; }
        public int QuestionNumber { get; set; }
    }
}
