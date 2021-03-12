using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class User
    {
        public User()
        {
            Announcements = new HashSet<Announcement>();
            CourseParticipants = new HashSet<CourseParticipant>();
            Courses = new HashSet<Course>();
            DocumentDownloadeds = new HashSet<DocumentDownloaded>();
            Documents = new HashSet<Document>();
            ExamAnsweredQuestions = new HashSet<ExamAnsweredQuestion>();
            Exams = new HashSet<Exam>();
            UserLogs = new HashSet<UserLog>();
            UserRoles = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }
        public virtual ICollection<CourseParticipant> CourseParticipants { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<DocumentDownloaded> DocumentDownloadeds { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<ExamAnsweredQuestion> ExamAnsweredQuestions { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<UserLog> UserLogs { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
