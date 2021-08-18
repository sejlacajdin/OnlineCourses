using OnlineCourseApp.Mobile.Models;
using OnlineCourseApp.Model;
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
        public GameManager _game;

        private string _question;
        public string Question
        {
            get { return _question; }
            set { SetProperty(ref _question, value); }
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

        private List<Choices> _choices;
        public List<Choices> Choices
        {
            get { return _choices; }
            set { SetProperty(ref _choices, value); }
        }

        public ICommand InitCommand { get; set; }
        public DelegateCommand NextCommand { get; private set; }
        public DelegateCommand EndCommand { get; private set; }

        public QuizViewModel()
        {

            InitCommand = new Command((game) => Init((GameManager)game));

            //_game.Reset();
            NextCommand = new DelegateCommand(OnNextClick).ObservesCanExecute(() => IsAnswered);
            EndCommand = new DelegateCommand(OnEndClick).ObservesCanExecute(() => IsAnswered);

        }

        public void Init(GameManager game)
        {
             _game = game;
         

            ShowNextQuestion();
        }

            public void OnNextClick()
        {
            ShowNextQuestion();
        }

        public void OnEndClick()
        {
            //_navigationService.NavigateAsync("/MainPage");
        }

        protected void ShowNextQuestion()
        {

            //IsAnswered = false;
            IsAnswered = true;

            var question = _game.NextQuestion();
            IsLastQuestion = _game.IsLastQuestion();

            Question = question.Text;
            Choices = question.Choices;

            //foreach (var item in question.Choices)
            //    Choices.Add(item);

        }
    }
}
