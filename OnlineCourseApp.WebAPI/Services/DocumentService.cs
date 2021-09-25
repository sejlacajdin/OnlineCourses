using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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
    public class DocumentService : BaseCRUDService<Model.Documents, DocumentsSearchRequest, DocumentsInsertRequest, DocumentsInsertRequest, Document>, IDocumentService
    {
        public DocumentService(_160065Context context, IMapper mapper) : base(context, mapper)
        { }

        public override List<Documents> Get(DocumentsSearchRequest request)
        {
            var query = _context.Set<DocumentShare>().AsQueryable();
            var document = _context.Set<Document>().AsQueryable();

            if (request?.CourseId != null)
                query = query.Where(x => x.CourseId == request.CourseId);

            if (!string.IsNullOrWhiteSpace(request?.FileOldName))
                query = query.Include(q => q.Document).Where(x => x.Document.FileOldName.StartsWith(request.FileOldName));


            var list = document.Where(x => query.Any(y => y.DocumentId == x.DocumentId)).ToList();

            return _mapper.Map<List<Documents>>(list);
        }
        public override Documents Delete(int id)
        {
            var entity = _context.Set<Document>().Find(id);
            var documentShare = _context.Set<DocumentShare>().AsQueryable().Where(d => d.DocumentId == id).FirstOrDefault();
            if (entity == null)
                throw new UserException("Document does not exist!");

            _context.Set<DocumentShare>().Remove(documentShare);
            _context.Set<Document>().Remove(entity);
            _context.SaveChanges();

            return _mapper.Map<Documents>(entity);
        }

        public Document GetLast()
        {
            int max = _context.Set<Document>().Max(x => x.DocumentId);
            return _context.Set<Document>().Find(max);
        }
        public Documents Upload(IFormFile file, int id)
        {
            if (file == null)
                throw new UserException("Document doesn't exist");

            Documents entity = null;
            //if (file.Length > 0)
            //    {
                    var fileName = Path.GetFileName(file.FileName);
                    var fileExtension = Path.GetExtension(fileName);
                    var contentType = file.ContentType;
                    var newFileName = String.Concat(Convert.ToString(Guid.NewGuid()), fileExtension);

                    string folder = "Resources/";
                    bool exists = Directory.Exists(folder);
                    if (!exists)
                        Directory.CreateDirectory(folder);

                    var path = Path.Combine(folder, newFileName);

                DocumentsInsertRequest doc = new DocumentsInsertRequest
                     {
                        FileOldName = fileName,
                        FileName = newFileName,
                        FileExstension = fileExtension,
                        UploadDate = DateTime.Now,
                        ContentType = contentType.Split(";")[0],
                        Path = path
                    };


                    using (var stream = new FileStream(folder + newFileName, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        stream.Close();
                    }

               entity = Insert(doc);

                DocumentsShareInsertRequest docShare = new DocumentsShareInsertRequest
                {
                        CourseId = id,
                        DocumentId = GetLast().DocumentId
                    };
                    var entityShare = _mapper.Map<DocumentShare>(docShare);
                    _context.Set<DocumentShare>().Add(entityShare);

                    _context.SaveChanges();

                //}
                return entity;

        }

        public FileDownload Download(int id)
        {
            var document = GetById(id);
            Byte[] b = System.IO.File.ReadAllBytes(document.Path);

            return new FileDownload
            {
                File = b,
                Name = document.FileOldName
            };
        }
    }
}
