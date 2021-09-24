using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class TransactionPayment
    {
        public int TransactionPaymentId { get; set; }
        public double? Price { get; set; }
        public string Token { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        public virtual Course Course { get; set; }
        public virtual User Student { get; set; }
    }
}
