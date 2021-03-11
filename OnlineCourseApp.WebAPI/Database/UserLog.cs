using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class UserLog
    {
        public int UserLogId { get; set; }
        public DateTime LoginTime { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
