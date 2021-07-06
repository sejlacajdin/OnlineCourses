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
    [Route("api/announcement-filters")]
    [ApiController]
    public class AnnouncementFilterController : BaseCRUDController<Model.AnnouncementFilters, AnnouncementFiltersSearchRequest, AnnouncementFiltersInsertRequest, AnnouncementFiltersInsertRequest>
    {
        public AnnouncementFilterController(IBaseCRUDService<Model.AnnouncementFilters, AnnouncementFiltersSearchRequest, AnnouncementFiltersInsertRequest, AnnouncementFiltersInsertRequest> service) : base(service)
        {
        }

    }
}
