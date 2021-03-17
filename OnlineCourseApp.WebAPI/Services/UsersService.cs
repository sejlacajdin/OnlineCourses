using AutoMapper;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests;
using OnlineCourseApp.Model.Requests.Users;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class UsersService : IUsersService
    {
        private readonly _160065Context _context;
        private readonly IMapper _mapper;
        public UsersService(_160065Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Users> Get(UsersSearchRequest request)
        {
            var query = _context.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.FirstName))
                query = query.Where(x => x.FirstName.StartsWith(request.FirstName));

            if (!string.IsNullOrWhiteSpace(request?.LastName))
                query = query.Where(x => x.LastName.StartsWith(request.LastName));

            var list = query.ToList();

            return _mapper.Map<List<Users>>(list);
        }

        public Users GetById(int id)
        {
            var entity = _context.Users.Find(id);
            if (entity == null)
                throw new UserException("User does not exist!");

            return _mapper.Map<Users>(entity);
        }
        public Users Insert(UsersInsertRequest request)
        {
            var entity = _mapper.Map<Database.User>(request);
            if (request.Password != request.PasswordConfirmation)
                throw new UserException("Passwords are not equal!");

            entity.PasswordHash = "test";
            entity.PasswordSalt = "test";

            _context.Users.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Users>(entity);
        }

        public Users Update(int id, UsersInsertRequest request)
        {
            var entity = _context.Users.Find(id);

            _mapper.Map(request, entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                    throw new UserException("Passwords are not equal!");
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Users>(entity);
        }
    }
}
