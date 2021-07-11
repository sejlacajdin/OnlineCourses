using OnlineCourseApp.Mobile.ViewModels;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.CourseParticipants;
using OnlineCourseApp.Model.Requests.Documents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineCourseApp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseDetailsPage : ContentPage
    {
        private readonly APIService _serviceDocuments = new APIService("document");
        private readonly APIService _serviceDocumentsDownloaded = new APIService("document-downloaded");
        private readonly APIService _serviceVideos = new APIService("video");
        private readonly APIService _serviceCourseParticipant = new APIService("course-participants");

        private CourseDetailsViewModel model = null;
        private int _courseId = 0;
        public CourseDetailsPage(object courseId)
        {
            InitializeComponent();
            BindingContext = model = new CourseDetailsViewModel();
            _courseId = (int)courseId;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
             model.InitCommand.Execute(_courseId);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var coursePax = await _serviceCourseParticipant.Get<List<CourseParticipants>>(new CourseParticipantsSearchRequest
            {
                CourseId = _courseId,
                StudentId = APIService.UserId
            });

            if (coursePax.Count == 0)
                await Navigation.PushAsync(new ReviewPage(_courseId));
            else
                await DisplayAlert("Info", "You have already reviewed this course.", "OK");
        }

        private Uri GetDocument(string filePath)
        {
            return new Uri(filePath);

        }
        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Documents;
            var doc = await _serviceDocuments.GetById<FileDownload>(item.DocumentId);

            try
            {
                var localPath = System.IO.Path.Combine(FileSystem.AppDataDirectory, doc.Name);
                //var localPath = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), doc.Name);
                File.WriteAllBytes(localPath, doc.File);

                GetDocument(localPath);

                await _serviceDocumentsDownloaded.Insert<DocumentsDownloaded>(new DocumentsDownloadedInsertRequest { DocumentId = item.DocumentId, StudentId = APIService.UserId });
                await DisplayAlert("Download", "Document successfully downloaded.", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Download", "Error while downloading document.", "OK");
            }
        }

        private async void listView1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Videos;
            var doc = await _serviceVideos.GetById<FileDownload>(item.VideoId);

            try
            {
                var localPath = System.IO.Path.Combine(FileSystem.AppDataDirectory, doc.Name);
                //var localPath = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), doc.Name);
                File.WriteAllBytes(localPath, doc.File);

                GetDocument(localPath);

                await DisplayAlert("Download", "Video successfully downloaded.", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Download", "Error while downloading video.", "OK");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}