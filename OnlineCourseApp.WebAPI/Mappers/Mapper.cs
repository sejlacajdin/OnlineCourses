using AutoMapper;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.Model.Requests.Users;
using OnlineCourseApp.Model.Requests.Videos;

namespace OnlineCourseApp.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.User, Model.Users>();
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


        }
    }
}
