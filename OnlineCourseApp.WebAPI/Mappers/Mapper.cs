using AutoMapper;
using OnlineCourseApp.Model.Requests.Announcements;
using OnlineCourseApp.Model.Requests.Choices;
using OnlineCourseApp.Model.Requests.CourseParticipants;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.Model.Requests.Exams;
using OnlineCourseApp.Model.Requests.Questions;
using OnlineCourseApp.Model.Requests.Users;
using OnlineCourseApp.Model.Requests.Videos;

namespace OnlineCourseApp.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.User, Model.Users>().ReverseMap();
            CreateMap<Database.UserRole, Model.UserRoles>();
            CreateMap<Database.Role, Model.Roles>();
            CreateMap<Database.User, UsersInsertRequest>().ReverseMap();
            CreateMap<Database.Course, Model.Courses>();
            CreateMap<Database.Course, CoursesInsertRequest>().ReverseMap();
            CreateMap<Database.CourseType, Model.CourseTypes>();
            CreateMap<Database.CourseSection, Model.CourseSections>();
            CreateMap<Database.Document, Model.Documents>();
            CreateMap<Database.Document, DocumentsInsertRequest>().ReverseMap();
            CreateMap<Database.DocumentShare, DocumentsShareInsertRequest>().ReverseMap();
            CreateMap<Database.Video, Model.Videos>().ReverseMap();
            CreateMap<Database.Video, VideosInsertRequest>().ReverseMap();
            CreateMap<Database.Exam, Model.Exams>();
            CreateMap<Database.Exam, ExamsInsertRequest>().ReverseMap();
            CreateMap<Database.Question, Model.Questions>();
            CreateMap<Database.Question, QuestionsInsertRequest>().ReverseMap();
            CreateMap<Database.QuestionCategory, Model.QuestionCategories>();
            CreateMap<Database.QuestionType, Model.QuestionTypes>();
            CreateMap<Database.Choice, Model.Choices>();
            CreateMap<Database.Choice, ChoicesInsertRequest>().ReverseMap();
            CreateMap<Database.Announcement, Model.Announcements>();
            CreateMap<Database.Announcement, AnnouncementsInsertRequest>().ReverseMap();
            CreateMap<Database.AnnouncementFilterType, Model.AnnouncementFilterTypes>();
            CreateMap<Database.AnnouncementFilter, Model.AnnouncementFilters>();
            CreateMap<Database.AnnouncementFilter, AnnouncementFiltersInsertRequest>().ReverseMap();
            CreateMap<Database.CourseParticipant, Model.CourseParticipants>();
            CreateMap<Database.CourseParticipant, CourseParticipantsInsertRequest>().ReverseMap();
            CreateMap<Database.DocumentDownloaded, Model.DocumentsDownloaded>();
            CreateMap<Database.DocumentDownloaded, DocumentsDownloadedInsertRequest>().ReverseMap();

        }
    }
}
