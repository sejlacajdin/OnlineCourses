using OnlineCourseApp.Mobile.Models;
using OnlineCourseApp.Mobile.Views;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.ExamAnsweredQuestions;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace OnlineCourseApp.Mobile.ViewModels
{
    public class QuizViewModel : BaseViewModel
    {
        private readonly APIService _serviceExamAnswers = new APIService("exam-answers");
        public GameManager _game;

        private string _question;
        public string Question
        {
            get { return _question; }
            set { SetProperty(ref _question, value); }
        }

        private bool _isFirstQuestion;
        public bool IsFirstQuestion
        {
            get { return _isFirstQuestion; }
            set { SetProperty(ref _isFirstQuestion, value); }
        }

        private bool _isLastQuestion;
        public bool IsLastQuestion
        {
            get { return _isLastQuestion; }
            set { SetProperty(ref _isLastQuestion, value); }
        }

        private bool _isAnswered;
        public bool IsAnswered
        {
            get { return _isAnswered; }
            set { SetProperty(ref _isAnswered, value); }
        }

        private string _time;
        public string Time
        {
            get { return _time; }
            set { SetProperty(ref _time, value); }
        }

        private List<Models.Choices> _choices;
        public List<Models.Choices> Choices
        {
            get { return _choices; }
            set { SetProperty(ref _choices, value); }
        }

        private ObservableCollection<string> _questionNumberList;
        public ObservableCollection<string> QuestionNumberList
        {
            get { return _questionNumberList; }
            set { SetProperty(ref _questionNumberList, value); }
        }

        private string _selectedQuestionNumber;
        public string SelectedQuestionNumber
        {
            get { return _selectedQuestionNumber; }
            set { SetProperty(ref _selectedQuestionNumber, value); }
        }

        public ICommand InitCommand { get; set; }
        public ICommand QuestionNumberCommand { get; set; }
        public DelegateCommand BackCommand { get; private set; }
        public DelegateCommand NextCommand { get; private set; }
        public DelegateCommand EndCommand { get; private set; }

        public QuizViewModel()
        {
            QuestionNumberList = new ObservableCollection<string>();
         
            InitCommand = new Command((game) => Init((GameManager)game));
            QuestionNumberCommand = new Command(() => ShowQuestionByNumber());

            //_game.Reset();
            BackCommand = new DelegateCommand(OnBackClick);
            //NextCommand = new DelegateCommand(OnNextClick).ObservesCanExecute(() => IsAnswered);
            NextCommand = new DelegateCommand(OnNextClick);
            EndCommand = new DelegateCommand(OnEndClick);

        }

        public void Init(GameManager game)
        {
            _game = game;

            TimeSpan Timer = TimeSpan.Parse(_game.StartTime);

            for (int i = 0; i < _game.Questions.Count; i++)
                QuestionNumberList.Add((i + 1).ToString());

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if(Timer.TotalSeconds > 0)
                {
                    Timer -= TimeSpan.FromSeconds(1);
                    Time = Timer.ToString();

                    return true;
                }else
                {
                     OnEndClick();
                    return false;
                }
            });

            ShowNextQuestion();
        }

        public void OnBackClick()
        {
            ShowPreviousQuestion();
        }

        public void OnNextClick()
        {
            ShowNextQuestion();
        }

        public async void OnEndClick()
        {
            foreach (var item in _game.Questions)
            {
                foreach (var choice in item.Choices)
                {
                    if (choice.IsSelected)
                    {
                        await _serviceExamAnswers.Insert<ExamAnsweredQuestionsInsertRequest>(new ExamAnsweredQuestionsInsertRequest
                        {
                               QuestionId = item.QuestionId,
                               StudentId = APIService.UserId,
                               ChoiceId = choice.ChoiceId,
                               Answer = choice.Text,
                               MarkScored = Math.Round(item.Points/100.00 *choice.Percentage,2)
                        });
                    }
                }
            }

            var score = await _serviceExamAnswers.Get<double>(new ExamAnsweredQuestionsSearchRequest { StudentId = APIService.UserId, ExamId = _game.Questions[0].ExamId });

            Application.Current.MainPage = new ExamFinishPage(score);
        }

        public void ShowQuestionByNumber()
        {
            //IsAnswered = false;
            IsAnswered = true;

            var question = _game.QuestionByNumber(int.Parse(SelectedQuestionNumber));
            IsLastQuestion = _game.IsLastQuestion();
            IsFirstQuestion = _game.IsFirstQuestion();

            Question = question.Text;
            Choices = question.Choices;
        }

        protected void ShowNextQuestion()
        {

            //IsAnswered = false;
            IsAnswered = true;

            var question = _game.NextQuestion();
            IsLastQuestion = _game.IsLastQuestion();
            IsFirstQuestion = _game.IsFirstQuestion();

            Question = question.Text;
            Choices = question.Choices;

        }

        protected void ShowPreviousQuestion()
        {

            //IsAnswered = false;
            IsAnswered = true;

            var question = _game.PreviousQuestion();
            IsLastQuestion = _game.IsLastQuestion();
            IsFirstQuestion = _game.IsFirstQuestion();

            Question = question.Text;
            Choices = question.Choices;

        }
    }
}
