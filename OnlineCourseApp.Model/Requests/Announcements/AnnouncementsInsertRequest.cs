using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Announcements
{
    public class AnnouncementsInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
        public int AnnouncementOwnerId { get; set; }
        public int FilterTypeId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string PostOwner { get; set; }
    }
}
