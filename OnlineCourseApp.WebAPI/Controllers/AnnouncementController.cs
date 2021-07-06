using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Announcements;
using OnlineCourseApp.WebAPI.Services;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{   [Authorize]
    [Route("api/announcements")]
    [ApiController]
    public class AnnouncementController : BaseCRUDController<Model.Announcements, AnnouncementsSearchRequest, AnnouncementsInsertRequest, AnnouncementsInsertRequest>
    {
        public AnnouncementController(IBaseCRUDService<Model.Announcements, AnnouncementsSearchRequest, AnnouncementsInsertRequest, AnnouncementsInsertRequest> service) : base(service)
        {
        }

    }
}
