using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests;
using OnlineCourseApp.Model.Requests.Users;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
        public Users Autenticiraj(string username, string pass)
        {
            var user = _context.Users.Include("UserRole.Role").FirstOrDefault(x => x.Username == username || x.Email == username);

            if(user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt,pass);
                if(newHash == user.PasswordHash)
                {
                    return _mapper.Map<Users>(user);
                }
            }

            return null;
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

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

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);


            _context.Users.Add(entity);
            _context.SaveChanges();

            var roleId = _context.Roles.Where(r => r.Name == request.Role).Select(r => r.RoleId).FirstOrDefault();
            _context.UserRoles.Add(new UserRole() { 
                
                RecordUpdated = DateTime.Now,
                RoleId = roleId,
                UserId = entity.UserId
            });

            //return _mapper.Map<Model.Users>(entity);
            return new Users
            {
                UserId = entity.UserId,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Username = entity.Username,
                Email = entity.Email,
                Phone = entity.Phone,
                Status = entity.Status
            };
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
