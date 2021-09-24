using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class TransactionPayment
    {
        public int TransactionPaymentId { get; set; }
        public double? Price { get; set; }
        public string Token { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
    }
}
