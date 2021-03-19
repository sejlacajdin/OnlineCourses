using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        IBaseCRUDService<T, TSearch, TInsert, TUpdate> _service = null;
        public BaseCRUDController(IBaseCRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public T Insert(TInsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public T Update(int id, [FromBody]TUpdate request)
        {
            return _service.Update(id,request);
        }

        [HttpDelete("{id}")]
        public T Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
