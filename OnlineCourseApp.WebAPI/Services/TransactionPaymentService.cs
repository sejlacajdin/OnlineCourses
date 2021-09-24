using AutoMapper;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.Model.Requests.TransactionPayment;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class TransactionPaymentService : BaseCRUDService<Model.TransactionPayment, object, TransactionPaymentInsertRequest, TransactionPaymentInsertRequest, Database.TransactionPayment>
    {
        public TransactionPaymentService(_160065Context context, IMapper mapper) : base(context, mapper)
        {

        }
    
    }
}
