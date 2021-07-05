using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Questions
{
    public class QuestionsInsertRequest
    {
        public int QuestionCategoryId { get; set; }
        public int QuestionTypeId { get; set; }
        public int ExamId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public double Points { get; set; }
        public bool IsActive { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Text { get; set; }
        public int QuestionNumber { get; set; }
    }
}
