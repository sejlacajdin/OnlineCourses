using OnlineCourseApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services.IServices
{
    public interface ICourseSectionService
    {
        List<CourseSections> Get();
        CourseSections GetById(int id);
    }
}
