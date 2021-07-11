using Microsoft.AspNetCore.Http;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.WebAPI.Database;


namespace OnlineCourseApp.WebAPI.Services.IServices
{
    public interface IDocumentDownloadedService
    {
        DocumentsDownloaded Insert(DocumentsDownloadedInsertRequest request);
    }
}
