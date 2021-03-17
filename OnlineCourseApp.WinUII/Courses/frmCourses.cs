using OnlineCourseApp.WinUI.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Courses
{
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmCoursesDetails frm = new frmCoursesDetails();
            frm.ShowDialog();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            cardsPanel1.ViewModel = LoadSomeData();
            cardsPanel1.DataBind();
        }

        private CardsViewModel LoadSomeData()
        {
            ObservableCollection<CardViewModel> cards = new ObservableCollection<CardViewModel>();
            cards.Add(new CardViewModel()
            {
                Age = 1,
                Name = "Dan",
            });
            cards.Add(new CardViewModel()
            {
                Age = 2,
                Name = "Gill",
            });
            cards.Add(new CardViewModel()
            {
                Age = 3,
                Name = "Glyn",
            });
            cards.Add(new CardViewModel()
            {
                Age = 4,
                Name = "Lorna",
            });
            cards.Add(new CardViewModel()
            {
                Age = 5,
                Name = "Holdly",
            });
            cards.Add(new CardViewModel()
            {
                Age = 5,
                Name = "Hoflly",
            });
            cards.Add(new CardViewModel()
            {
                Age = 5,
                Name = "Hoslly",
            });
            cards.Add(new CardViewModel()
            {
                Age = 5,
                Name = "Holasly",
            });
            CardsViewModel VM = new CardsViewModel()
            {
                Cards = cards
            };
            return VM;
        }
    }
}
