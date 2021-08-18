using OnlineCourseApp.Mobile.Models;
using OnlineCourseApp.Mobile.Views;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Choices;
using OnlineCourseApp.Model.Requests.Exams;
using OnlineCourseApp.Model.Requests.Questions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace OnlineCourseApp.Mobile.ViewModels
{
    public class ExamViewModel : BaseViewModel
    {
        private readonly APIService _serviceExams = new APIService("exams");
        private readonly APIService _serviceQuestions = new APIService("questions");
        private readonly APIService _serviceChoices = new APIService("choices");
        public ICommand InitCommand { get; set; }
        public DelegateCommand StartCommand { get; private set; }

        private readonly GameManager _game;

        Exams _exam = null;
        public Exams Exam
        {
            get { return _exam; }
            set
            {
                SetProperty(ref _exam, value);
            }
        }

        public ExamViewModel()
        {
            InitCommand = new Command(async (courseId) => await Init((int)courseId));
            StartCommand = new DelegateCommand(OnStartClick);
            _game = new GameManager();

        }

        public async Task Init(int courseId)
        {
            var exams = await _serviceExams.Get<List<Exams>>(new ExamsSearchRequest { CourseId = courseId });

            if (exams.Count > 0 && exams?[0].IsActive == true)
                Exam = exams[0];
        }

        public async void OnStartClick()
        {
            _game.Questions = await _serviceQuestions.Get<List<Models.Questions>>(new QuestionsSearchRequest { ExamId = Exam.ExamId, IsActive = true });

            foreach (var item in _game.Questions)
            {
                item.Choices = await _serviceChoices.Get<List<Choices>>(new ChoicesSearchRequest { QuestionId = item.QuestionId });
            }
            Application.Current.MainPage = new NavigationPage(new QuizesPage(_game));
        }

    }
}