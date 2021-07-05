using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model.Requests.Choices;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Authorize]
    [Route("api/choices")]
    [ApiController]
    public class ChoiceController : BaseCRUDController<Model.Choices, ChoicesSearchRequest, ChoicesInsertRequest, ChoicesInsertRequest>
    {
        public ChoiceController(IBaseCRUDService<Model.Choices, ChoicesSearchRequest, ChoicesInsertRequest, ChoicesInsertRequest> service) : base(service)
        {
        }
    }
}