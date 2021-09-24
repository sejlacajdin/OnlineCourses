using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class Course
    {
        public Course()
        {
            AnnouncementFilters = new HashSet<AnnouncementFilter>();
            CourseParticipants = new HashSet<CourseParticipant>();
            DocumentShares = new HashSet<DocumentShare>();
            Exams = new HashSet<Exam>();
            TransactionPayments = new HashSet<TransactionPayment>();
            Videos = new HashSet<Video>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Notes { get; set; }
        public int ProfessorId { get; set; }
        public bool IsActive { get; set; }
        public int CourseSectionId { get; set; }
        public byte[] Picture { get; set; }
        public byte[] PictureThumb { get; set; }
        public double? Rating { get; set; }
        public int? NumOfRatings { get; set; }
        public double? Price { get; set; }

        public virtual CourseSection CourseSection { get; set; }
        public virtual User Professor { get; set; }
        public virtual ICollection<AnnouncementFilter> AnnouncementFilters { get; set; }
        public virtual ICollection<CourseParticipant> CourseParticipants { get; set; }
        public virtual ICollection<DocumentShare> DocumentShares { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<TransactionPayment> TransactionPayments { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
