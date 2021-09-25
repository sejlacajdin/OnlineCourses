using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Choices
{
    public class ChoicesSearchRequest
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
    }
}
