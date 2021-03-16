using AutoMapper;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.Model.Requests.Users;

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


        }
    }
}
