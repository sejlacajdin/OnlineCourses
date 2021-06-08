using AutoMapper;
using Microsoft.AspNetCore.Http;
using OnlineCourseApp.Model;
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
    }
}
