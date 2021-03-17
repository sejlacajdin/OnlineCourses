﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests;
using OnlineCourseApp.Model.Requests.Users;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public ActionResult<List<Users>> Get([FromQuery] UsersSearchRequest request)
        {
            return _usersService.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Users> GetById(int id)
        {
            return _usersService.GetById(id);
        }

        [HttpPost]
        public Model.Users Insert(UsersInsertRequest request)
        {
            return _usersService.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Users Update(int id, UsersInsertRequest request)
        {
            return _usersService.Update(id, request);
        }
    }
}
