using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Documents
{
    public class FileDownload
    {
        public byte[] File { get; set; }
        public string Name { get; set; }
    }
}
