using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.Model.Requests.TransactionPayment;
using OnlineCourseApp.WebAPI.Services;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{   [Authorize]
    [Route("api/transaction-payment")]
    [ApiController]
    public class TransactionPaymentController : BaseCRUDController<Model.TransactionPayment, object, TransactionPaymentInsertRequest, TransactionPaymentInsertRequest>
    {
        public TransactionPaymentController(IBaseCRUDService<Model.TransactionPayment, object, TransactionPaymentInsertRequest, TransactionPaymentInsertRequest> service) : base(service)
        {
        }
    }
}
