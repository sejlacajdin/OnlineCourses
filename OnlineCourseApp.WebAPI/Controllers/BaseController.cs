using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase
    {
        private readonly IBaseService<T, TSearch> _baseService;

        public BaseController(IBaseService<T, TSearch> baseService)
        {
            _baseService = baseService;
        }
        [HttpGet]
        public List<T> Get([FromQuery]TSearch search)
        {
            return _baseService.Get(search);
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _baseService.GetById(id);
        }

       
    }
}
