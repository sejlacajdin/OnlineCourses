using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Mobile.Models
{
    public class GameManager
    {
        public List<Questions> Questions { get; set; }
        public int Score { get; private set; }
        private int _currentQuestionIndex = -1;

        public Questions CurrentQuestion
        {
            get
            {
                return _currentQuestionIndex < Questions.Count ? Questions[_currentQuestionIndex] : null;
            }
        }

        public GameManager()
        {
            Questions = new List<Questions>();
        }

        //public bool AnswerCurrentQuestion(bool yes)
        //{
        //    if (CurrentQuestion == null) return false;

        //    var correct = CurrentQuestion.ValidateAnswer(yes);

        //    if (correct)
        //        Score++;

        //    return correct;
        //}

        public void Reset()
        {
            Score = 0;
            _currentQuestionIndex = -1;
        }


        public Questions NextQuestion()
        {
            _currentQuestionIndex++;

            return CurrentQuestion;
        }

        public bool IsLastQuestion()
        {
            return (_currentQuestionIndex == Questions.Count - 1);
        }

    }
}
