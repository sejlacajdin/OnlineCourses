using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Choices
{
    public class ChoicesInsertRequest
    {
        public int QuestionId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Text { get; set; }

        [Required]
        public double Percentage { get; set; }
        public bool? IsCorrect { get; set; }
    }
}
