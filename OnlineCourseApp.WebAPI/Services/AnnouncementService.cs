using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Announcements;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class AnnouncementService : BaseCRUDService<Model.Announcements, AnnouncementsSearchRequest, AnnouncementsInsertRequest, AnnouncementsInsertRequest, Announcement>
    {
        public AnnouncementService(_160065Context context, IMapper mapper) : base(context, mapper)
        {

        }
       
        public override List<Announcements> Get(AnnouncementsSearchRequest request)
        {
            var query = _context.Set<Announcement>().AsQueryable();

            if (request?.AnnouncementOwnerId != 0)
                query = query.Where(x => x.AnnouncementOwnerId == request.AnnouncementOwnerId);

            if (request?.FilterTypeId?.Count != 0 && request?.AnnouncementOwnerId == 0)
                query = query.Where(x => request.FilterTypeId.Contains(x.FilterTypeId));

            if (!string.IsNullOrWhiteSpace(request?.Title))
                query = query.Where(x => x.Title.StartsWith(request.Title));

            var list = query.ToList();

            return _mapper.Map<List<Announcements>>(list);
        }
     }
}
