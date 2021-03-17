using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Courses
{
    public class CoursesInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string CourseName { get; set; }
        public string Notes { get; set; }
        [Required]
        public int ProfessorId { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public int CourseSectionId { get; set; }
        public byte[] Picture { get; set; }
        public byte[] PictureThumb { get; set; }
    }
}
