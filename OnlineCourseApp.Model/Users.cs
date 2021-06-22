using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
        public  ICollection<UserRoles> UserRoles { get; set; }
    }
}
