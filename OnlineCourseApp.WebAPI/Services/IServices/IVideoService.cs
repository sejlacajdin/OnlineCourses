using Microsoft.AspNetCore.Http;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.WebAPI.Database;


namespace OnlineCourseApp.WebAPI.Services.IServices
{
    public interface IVideoService
    {
        Videos Upload(IFormFile file, int courseId);
        FileDownload Download(int id);
    }
}
