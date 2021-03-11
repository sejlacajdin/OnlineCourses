using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class QuestionCategory
    {
        public QuestionCategory()
        {
            Questions = new HashSet<Question>();
        }

        public int QuestionCategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
