using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.Model.Requests.Videos;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Authorize]
    [Route("api/video")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IVideoService _videoService;
        private readonly IBaseCRUDService<Videos, VideosSearchRequest, VideosInsertRequest, VideosInsertRequest> _service = null;

        public VideoController(IVideoService videoService, IBaseCRUDService<Videos, VideosSearchRequest, VideosInsertRequest, VideosInsertRequest> service)
        {
            _videoService = videoService;
            _service = service;
        }

        [HttpGet]
        public List<Videos> Get([FromQuery] VideosSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public FileDownload GetById(int id)
        {
            return _videoService.Download(id);
        }

        [HttpPost("upload/{id}")]
        public Videos Insert(IFormFile file, int id)
        {
            return _videoService.Upload(file, id);

        }

        [HttpDelete("{id}")]
        public Videos Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
