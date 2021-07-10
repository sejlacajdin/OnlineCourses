using OnlineCourseApp.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace OnlineCourseApp.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}