using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Choices
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();
        }

        private void btnAddChoice_Click(object sender, EventArgs e)
        {
            frmChoiceAdd frm = new frmChoiceAdd();
            frm.ShowDialog();
        }
    }
}
