using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Authorize]
    [Route("api/course-recommender")]
    [ApiController]
    public class RecommenderController : ControllerBase
    {
        private readonly IRecommenderService _service;
        public RecommenderController(IRecommenderService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public List<Courses> Get(int id)
        {
            return _service.GetRecommended(id);
        }

    }
}
