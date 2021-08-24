using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Mobile.Models
{
    public class GameManager
    {
        public List<Questions> Questions { get; set; }
        public string StartTime { get; set; }
        private int _currentQuestionIndex = -1;

        public Questions CurrentQuestion
        {
            get
            {
                return _currentQuestionIndex < Questions.Count && _currentQuestionIndex >= 0 ? Questions[_currentQuestionIndex] : null;
            }
        }

        public GameManager()
        {
            Questions = new List<Questions>();
        }

        public void Reset()
        {
            _currentQuestionIndex = -1;
        }


        public Questions NextQuestion()
        {
            _currentQuestionIndex++;

            return CurrentQuestion;
        }

        public Questions PreviousQuestion()
        {
            _currentQuestionIndex--;

            return CurrentQuestion;
        }

        public Questions QuestionByNumber(int questionIndex)
        {
            _currentQuestionIndex = questionIndex -1;

            return CurrentQuestion;
        }
        public bool IsLastQuestion()
        {
            return (_currentQuestionIndex == Questions.Count - 1);
        }

        public bool IsFirstQuestion()
        {
            return (_currentQuestionIndex == 0);
        }
    }
}
