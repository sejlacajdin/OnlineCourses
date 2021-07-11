using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Authorize]
    [Route("api/document-downloaded")]
    [ApiController]
    public class DocumentDownloadedController : ControllerBase
    {
        private readonly IDocumentDownloadedService _documentDownloadedService;

        public DocumentDownloadedController(IDocumentDownloadedService documentDownloadedService)
        {
            _documentDownloadedService = documentDownloadedService;
        }

        [HttpPost]
        public DocumentsDownloaded Insert(DocumentsDownloadedInsertRequest request)
        {
            return _documentDownloadedService.Insert(request);

        }

    }
}
