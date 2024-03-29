﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class Courses
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Notes { get; set; }
        public int ProfessorId { get; set; }
        public bool IsActive { get; set; }
        public double? Price { get; set; }
        public double? Rating { get; set; }
        public int? NumOfRatings { get; set; }
        public int CourseSectionId { get; set; }
        public byte[] Picture { get; set; }

        public float? FinalRating { get; set; }
    }
}
