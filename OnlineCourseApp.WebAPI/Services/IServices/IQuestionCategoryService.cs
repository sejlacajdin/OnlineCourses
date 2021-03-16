﻿using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services.IServices
{
    public interface IQuestionCategoryService
    {
        List<QuestionCategories> Get();
    }
}
