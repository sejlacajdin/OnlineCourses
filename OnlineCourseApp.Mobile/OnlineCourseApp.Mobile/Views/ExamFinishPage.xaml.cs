using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineCourseApp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExamFinishPage : ContentPage
    {
        public double Score { get; set; }
        public ExamFinishPage(double score)
        {
            this.Score = score;
            InitializeComponent();
            scoreTxt.Text = score.ToString() + '%';
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             Application.Current.MainPage = new MyCoursesPage();

        }
    }
}