using AutoMapper;
using Microsoft.AspNetCore.Http;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.Model.Requests.Videos;
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
    public class VideoService : BaseCRUDService<Model.Videos, VideosSearchRequest, VideosInsertRequest, VideosInsertRequest, Video>, IVideoService
    {
        public VideoService(_160065Context context, IMapper mapper) : base(context, mapper)
        { }

        public override List<Videos> Get(VideosSearchRequest request)
        {
            var query = _context.Set<Video>().AsQueryable();

            if (request?.CourseId != null)
                query = query.Where(x => x.CourseId == request.CourseId);

            if (!string.IsNullOrWhiteSpace(request?.Name))
                query = query.Where(x => x.Name.StartsWith(request.Name));


            var list = query.ToList();

            return _mapper.Map<List<Videos>>(list);
        }
        public Videos Upload(IFormFile file, int id)
        {
            if (file == null)
                throw new UserException("Video doesn't exist");

            Videos entity = null;
                    var fileName = Path.GetFileName(file.FileName);
                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        var fileInBytes = Convert.ToBase64String(fileBytes);
                        VideosInsertRequest doc = new VideosInsertRequest
                        {
                                    CourseId = id,
                                    Name = fileName,
                                    Size = file.Length,
                                    File = fileBytes
                        };
                    entity = Insert(doc);
                    }       

                return entity;

        }

        public FileDownload Download(int id)
        {
            var video = GetById(id);
            return new FileDownload
            {
                File = video.File,
                Name = video.Name
            };
        }
    }
}
