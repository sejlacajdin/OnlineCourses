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
    public class AnnouncementFiltersService : BaseCRUDService<Model.AnnouncementFilters, AnnouncementFiltersSearchRequest, AnnouncementFiltersInsertRequest, AnnouncementFiltersInsertRequest, AnnouncementFilters>
    {
        public AnnouncementFiltersService(_160065Context context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<AnnouncementFilters> Get(AnnouncementFiltersSearchRequest request)
        {
            var query = _context.Set<AnnouncementFilter>().AsQueryable();

            if (request?.AnnouncementId != 0)
                query = query.Where(x => x.AnnouncementId == request.AnnouncementId);

            if (request?.CourseId != 0 && request?.CourseId != null)
                query = query.Where(x => x.CourseId == request.CourseId);

            if (request?.CourseSectionId != 0 && request?.CourseSectionId != null)
                query = query.Where(x => x.CourseSectionId == request.CourseSectionId);


            if (request?.CourseTypeId != 0 && request?.CourseTypeId != null)
                query = query.Where(x => x.CourseTypeId == request.CourseTypeId);

            var list = query.ToList();

            return _mapper.Map<List<AnnouncementFilters>>(list);
        }

        public override AnnouncementFilters Insert(AnnouncementFiltersInsertRequest request)
        {
            var entity = new AnnouncementFilter
            {
                AnnouncementId = request.AnnouncementId,
                CourseId = request.CourseId != 0? request.CourseId : null,
                CourseSectionId = request.CourseSectionId != 0 ? request.CourseSectionId : null,
                CourseTypeId = request.CourseTypeId != 0 ? request.CourseTypeId : null
            };

            _context.Set<AnnouncementFilter>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<AnnouncementFilters>(entity);
        }

        public override AnnouncementFilters Update(int id, AnnouncementFiltersInsertRequest request)
        {
            var entity = _context.Set<AnnouncementFilter>().Where(a => a.AnnouncementId == id).FirstOrDefault();
            _context.Set<AnnouncementFilter>().Attach(entity);

            entity.AnnouncementId = request.AnnouncementId;
            entity.CourseId = request.CourseId != 0 ? request.CourseId : null;
            entity.CourseSectionId = request.CourseSectionId != 0 ? request.CourseSectionId : null;
            entity.CourseTypeId = request.CourseTypeId != 0 ? request.CourseTypeId : null;

            _context.Set<AnnouncementFilter>().Update(entity);
            _context.SaveChanges();

            return _mapper.Map<AnnouncementFilters>(entity);

        }

        public override AnnouncementFilters Delete(int id)
        {
            var entity = _context.Set<AnnouncementFilter>().Where(a => a.AnnouncementId == id).FirstOrDefault();
            if (entity == null)
                throw new UserException("Does not exist!");

            _context.Set<AnnouncementFilter>().Remove(entity);
            _context.SaveChanges();

            return _mapper.Map<AnnouncementFilters>(entity);
        }
    }
}
