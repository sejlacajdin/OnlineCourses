using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Announcements;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.Model.Requests.Exams;
using OnlineCourseApp.Model.Requests.Questions;
using OnlineCourseApp.Model.Requests.Videos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace OnlineCourseApp.Mobile.ViewModels
{
    public class CourseDetailsViewModel : BaseViewModel
    {
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceDocuments = new APIService("document");
        private readonly APIService _serviceVideos = new APIService("video");
        private readonly APIService _serviceAnnouncementFilter = new APIService("announcement-filters");
        private readonly APIService _serviceAnnouncement = new APIService("announcements");
        private readonly APIService _serviceExams = new APIService("exams");
        private readonly APIService _serviceExamAnswers = new APIService("exam-answers");
        public CourseDetailsViewModel()
        {
            InitCommand = new Command(async (courseId) => await Init((int)courseId));
        }

        Courses _course = null;
        public Courses Course
        {
            get { return _course; }
            set
            {
                SetProperty(ref _course, value);
            }
        }

        bool _isButtonVisible = true;
        public bool IsButtonVisible
        {
            get { return _isButtonVisible; }
            set
            {
                SetProperty(ref _isButtonVisible, value);
            }
        }

        bool _isScoreVisible = true;
        public bool IsScoreVisible
        {
            get { return _isScoreVisible; }
            set
            {
                SetProperty(ref _isScoreVisible, value);
            }
        }

        string _score;
        public string Score
        {
            get { return _score; }
            set
            {
                SetProperty(ref _score, value);
            }
        }

        public ICommand InitCommand { get; set; }
        public ObservableCollection<Documents> Documents { get; set; } = new ObservableCollection<Documents>();
        public ObservableCollection<Videos> Videos { get; set; } = new ObservableCollection<Videos>();
        public ObservableCollection<Announcements> Announcements { get; set; } = new ObservableCollection<Announcements>();

        public async Task Init(int courseId)
        {
            Course = await _serviceCourses.GetById<Courses>(courseId);

            var document = await _serviceDocuments.Get<List<Documents>>(new DocumentsSearchRequest{ CourseId = courseId});
            var video = await _serviceVideos.Get<List<Videos>>(new VideosSearchRequest { CourseId = courseId });
            var announcementFilters = await _serviceAnnouncementFilter.Get<List<AnnouncementFilters>>(new AnnouncementFiltersSearchRequest { CourseId = courseId });
            var exams = await _serviceExams.Get<List<Exams>>(new ExamsSearchRequest { CourseId = courseId, IsActive = true });

            if (exams.Count > 0)
            {

            var examResults = await _serviceExamAnswers.Get<double>(new ExamAnsweredQuestionsSearchRequest { StudentId = APIService.UserId, ExamId = exams[0].ExamId });
                if(examResults == -1)
                {
                    Score = "";
                    IsButtonVisible = true;
                    IsScoreVisible = false;
                }
                else
                {
                    Score = examResults.ToString()+'%';
                    IsButtonVisible = false;
                    IsScoreVisible = true;
                }
            }
            else
            {
                Score = "";
                IsButtonVisible = false;
            IsScoreVisible = true;

            }


            if (announcementFilters.Count > 0)
            {
                foreach (var item in announcementFilters)
                {
                    var announcement = await _serviceAnnouncement.GetById<Announcements>(item.AnnouncementId);
                    if (announcement.FilterTypeId == 1 || announcement.FilterTypeId == 3)
                        Announcements.Add(announcement);
                }
            }

            foreach (var item in document)
                Documents.Add(item);

            foreach (var item in video)
                Videos.Add(item);

        }
    }
}
