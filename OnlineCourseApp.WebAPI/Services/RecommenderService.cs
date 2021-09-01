using AutoMapper;
using OnlineCourseApp.Model;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class RecommenderService : IRecommenderService
    {
        private _160065Context _context = null;
        private IMapper _mapper = null;
        private Dictionary<int, List<CourseParticipant>> review = new Dictionary<int, List<CourseParticipant>>();
        public RecommenderService(_160065Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Courses> GetRecommended(int courseId)
        {
            GetCourses(courseId);
            List<CourseParticipant> coursePaxCourse = _context.Set<CourseParticipant>().AsQueryable().Where(c => c.CourseId == courseId).OrderBy(x => x.StudentId).ToList();

            List<CourseParticipant> coursePaxCourse1 = new List<CourseParticipant>();
            List<CourseParticipant> coursePaxCourse2 = new List<CourseParticipant>();
            List<Courses> recommendetCourse = new List<Courses>();

            foreach (var item in review)
            {
                foreach (var myReviews in coursePaxCourse)
                {
                    if(item.Value.Where(x => x.StudentId == myReviews.StudentId).Count() > 0)
                    {
                        coursePaxCourse1.Add(myReviews);
                        coursePaxCourse2.Add(item.Value.First(x => x.StudentId == myReviews.StudentId));
                    }
                }

                double similarity = GetSimilarity(coursePaxCourse1, coursePaxCourse2);
                if (similarity > 0.5)
                    recommendetCourse.Add(_mapper.Map<Courses>(_context.Set<Course>().Find(item.Key)));
                coursePaxCourse1.Clear();
                coursePaxCourse2.Clear();
            }

            return recommendetCourse;
        }

        private double GetSimilarity(List<CourseParticipant> coursePaxCourse1, List<CourseParticipant> coursePaxCourse2)
        {
            if (coursePaxCourse1.Count != coursePaxCourse2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for(int i = 0; i< coursePaxCourse1.Count; i++)
            {
                brojnik += coursePaxCourse1[i].Review * coursePaxCourse2[i].Review;
                nazivnik1 += coursePaxCourse1[i].Review * coursePaxCourse1[i].Review;
                nazivnik2 += coursePaxCourse2[i].Review * coursePaxCourse2[i].Review;
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;

            return brojnik / nazivnik;
        }

        private void GetCourses(int id)
        {
            var query = _context.Set<Course>().AsQueryable();

            if (id != 0)
                query = query.Where(x => x.CourseId != id && x.IsActive == true );
            var list = query.ToList();

            var coursePax = new List<CourseParticipant>();

            foreach (var item in list)
            {

                coursePax = _context.Set<CourseParticipant>().AsQueryable().Where(c => c.CourseId == item.CourseId).OrderBy(x => x.StudentId).ToList();
               if(coursePax.Count > 0)
                review.Add(item.CourseId, coursePax);
            }
        }
    }
}
