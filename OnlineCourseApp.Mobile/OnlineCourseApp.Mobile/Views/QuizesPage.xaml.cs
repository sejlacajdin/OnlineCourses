using OnlineCourseApp.Mobile.Models;
using OnlineCourseApp.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineCourseApp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizesPage : ContentPage
    {
        private QuizViewModel model = null;
        private GameManager _game = null;
        public QuizesPage(GameManager game)
        {
            InitializeComponent();
            _game = game;
            BindingContext = model = new QuizViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.InitCommand.Execute(_game);
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.QuestionNumberCommand.Execute(null);
        }
    }
}