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
    [Route("api/document")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        private readonly IBaseCRUDService<Documents, DocumentsSearchRequest, DocumentsInsertRequest, DocumentsInsertRequest> _service = null;

        public DocumentController(IDocumentService documentService, IBaseCRUDService<Documents, DocumentsSearchRequest, DocumentsInsertRequest, DocumentsInsertRequest> service)
        {
            _documentService = documentService;
            _service = service;
        }

        [HttpGet]
        public List<Documents> Get([FromQuery] DocumentsSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public Documents GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost("upload/{id}")]
        public Documents Insert(IFormFile file, int id)
        {
            return _documentService.Upload(file, id);

        }

        [HttpDelete("{id}")]
        public Documents Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
