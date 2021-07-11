using AutoMapper;
using Microsoft.AspNetCore.Http;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class DocumentDownloadedService :  IDocumentDownloadedService
    {
        private _160065Context _context = null;
        private IMapper _mapper = null;
        public DocumentDownloadedService(_160065Context context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

      public DocumentsDownloaded Insert(DocumentsDownloadedInsertRequest request)
        {
            var docShare = _context.Set<DocumentShare>().AsQueryable().Where(x => x.DocumentId == request.DocumentId).FirstOrDefault();
            if (docShare != null)
            {
                _context.Set<DocumentDownloaded>().Add(new DocumentDownloaded { DocumentShareId = docShare.DocumentShareId, StudentId = request.StudentId });
                _context.SaveChanges();

            }

            return new DocumentsDownloaded { 
                DocumentShareId = docShare.DocumentShareId,
                StudentId = request.StudentId
            };
        }


    }
}
