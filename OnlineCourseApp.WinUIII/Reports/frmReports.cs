using Microsoft.Reporting.WinForms;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.CourseParticipants;
using OnlineCourseApp.Model.Requests.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Reports
{
    public partial class frmReports : Form
    {
        private readonly APIService _serviceCourseParticipant = new APIService("course-participants");
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceUser = new APIService("users");
        public frmReports()
        {
            InitializeComponent();
        }

        

        private async void frmReports_Load(object sender, EventArgs e)
        {

            var courses =await  _serviceCourses.Get<List<Model.Courses>>(new CoursesSearchRequest { ProfessorId = APIService.UserId });
            double? totalRevenue = 0;
            int totalEnrollments = 0;
            double rating = 0;
            var listPax = new List<object>();

            foreach (var item in courses)
            {
                var coursePax =await  _serviceCourseParticipant.Get<List<CourseParticipants>>(new CourseParticipantsSearchRequest { CourseId = item.CourseId });
                if(item.Price != null)
                totalRevenue += item.Price * coursePax.Count;
                totalEnrollments += coursePax.Count;

                var RatingTemp = 0;
                foreach (var item1 in coursePax)
                {
                    RatingTemp += item1.Review;

                    var student = await _serviceUser.GetById<Model.Users>(item1.StudentId);

                    listPax.Add(new
                    {
                        Id= item.CourseId,
                        Name= item.CourseName,
                        Date = item1.ParticipationDate.ToShortDateString(),
                        ParticipantName = student.FirstName+' '+student.LastName,
                        Review = item1.Review

                    });
                }

                if(coursePax.Count > 0)
                rating += RatingTemp / coursePax.Count;
            }

            if (courses.Count > 0)
                rating /= courses.Count;



            ReportParameterCollection reportParameterCollection = new ReportParameterCollection();
            reportParameterCollection.Add(new ReportParameter("TotalRevenue", totalRevenue.ToString()));
            reportParameterCollection.Add(new ReportParameter("TotalEnrollments", totalEnrollments.ToString()));
            reportParameterCollection.Add(new ReportParameter("Rating", Math.Round(rating, 2).ToString()));

 
            var rds = new ReportDataSource();

            rds.Name = "DataSet1";
            rds.Value = listPax;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(reportParameterCollection);

            this.reportViewer1.RefreshReport();
        }
    }
}
