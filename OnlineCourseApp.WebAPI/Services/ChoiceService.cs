using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Choices;
using OnlineCourseApp.Model.Requests.Questions;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class ChoiceService : BaseCRUDService<Model.Choices, ChoicesSearchRequest, ChoicesInsertRequest, ChoicesInsertRequest, Choice>
    {
        public ChoiceService(_160065Context context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Choices> Get(ChoicesSearchRequest request)
        {
            var query = _context.Set<Choice>().AsQueryable();

            if (request?.QuestionId != null)
                query = query.Where(x => x.QuestionId == request.QuestionId);

            if (!string.IsNullOrWhiteSpace(request?.Text))
                query = query.Where(x => x.Text.StartsWith(request.Text));


            var list = query.ToList();

            return _mapper.Map<List<Choices>>(list);
        }

    }
}
