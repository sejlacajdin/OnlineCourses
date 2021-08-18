using OnlineCourseApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Mobile.Models
{
    public class Questions
    {
        public Questions()
        {
            Choices = new List<Choices>();
        }
        public int QuestionId { get; set; }
        public int QuestionCategoryId { get; set; }
        public int QuestionTypeId { get; set; }
        public int ExamId { get; set; }
        public double Points { get; set; }
        public bool IsActive { get; set; }
        public string Text { get; set; }
        public int QuestionNumber { get; set; }
        public List<Choices> Choices { get; set; }
    }
}
