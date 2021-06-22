using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class UserRoles
    {
        public int UserRolesId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime RecordUpdated { get; set; }

        public Roles Role { get; set; }
        public Users User { get; set; }
    }
}
