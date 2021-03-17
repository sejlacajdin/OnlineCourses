using OnlineCourseApp.WinUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI
{

    public partial class CardsPanel : Panel
    {
        const int CardWidth = 200;
        const int CardHeight = 150;

        public CardsViewModel ViewModel { get; set; }

        public CardsPanel()
        {
        }
        public CardsPanel(CardsViewModel viewModel)
        {
            ViewModel = viewModel;
            ViewModel.Cards.CollectionChanged += Cards_CollectionChanged;
        }

        private void Cards_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            DataBind();
        }

        public void DataBind()
        {
            SuspendLayout();
            Controls.Clear();

            for (int i = 0; i < ViewModel.Cards.Count; i++)
            {
                var newCtl = new CardControl(ViewModel.Cards[i]);
                newCtl.DataBind();
                SetCardControlLayout(newCtl, i);
                Controls.Add(newCtl);
            }
            ResumeLayout();
        }

        void SetCardControlLayout(CardControl ctl, int atIndex)
        {
            ctl.Width = CardWidth;
            ctl.Height = CardHeight;
            
            //calc visible column count
            int columnCount = Width / CardWidth;

            //calc the x index and y index.
            int xPos = (atIndex % columnCount) * (CardWidth+20);
            int yPos = (atIndex / columnCount) * (CardHeight+20);

            ctl.Location = new Point(xPos, yPos);
        }
    }

}
