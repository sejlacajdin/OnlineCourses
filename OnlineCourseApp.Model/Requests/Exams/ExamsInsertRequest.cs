using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Exams
{
    public class ExamsInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }
        public string TimeLimit { get; set; }
        public bool IsActive { get; set; }
        public string Instructions { get; set; }
        public int CourseId { get; set; }
        public int ExamOwnerId { get; set; }
    }
}
