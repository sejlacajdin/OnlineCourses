using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Controls
{
    public partial class CardControl : UserControl
    {
        public CardViewModel ViewModel { get; set; }

        public CardControl()
        {
            InitializeComponent();
        }
        public CardControl(CardViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }

        public void DataBind()
        {
            SuspendLayout();

            label1.Text = ViewModel.Age.ToString();
            label1.Name = ViewModel.Name;
            //pbPicture.Image = ViewModel.Picture;

            ResumeLayout();
        }

    }

    public class CardsViewModel
    {
        public ObservableCollection<CardViewModel> Cards { get; set; }
    }

    public class CardViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //public Bitmap Picture { get; set; }
    }
}
