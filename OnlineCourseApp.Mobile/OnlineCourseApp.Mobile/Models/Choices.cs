using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Mobile.Models
{
    public class Choices
    {
        public int ChoiceId { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public double Percentage { get; set; }
        public bool? IsCorrect { get; set; }

        public bool IsSelected { get; set; }
    }
}
