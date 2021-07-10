using AutoMapper;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.CourseParticipants;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class CourseParticipantService : BaseCRUDService<Model.CourseParticipants, CourseParticipantsSearchRequest, CourseParticipantsInsertRequest, CourseParticipantsInsertRequest, CourseParticipant>
    {
        public CourseParticipantService(_160065Context context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<CourseParticipants> Get(CourseParticipantsSearchRequest request)
        {
            var query = _context.Set<CourseParticipant>().AsQueryable();

            if (request?.CourseId != null && request?.CourseId != 0)
                query = query.Where(x => x.CourseId == request.CourseId);

            if (request?.StudentId != null && request?.StudentId != 0)
                query = query.Where(x => x.StudentId == request.StudentId);

            var list = query.ToList();

            return _mapper.Map<List<CourseParticipants>>(list);
        }
    }
}
