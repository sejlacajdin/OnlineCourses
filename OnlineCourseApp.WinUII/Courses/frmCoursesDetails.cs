using Flurl.Http;
using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.Model.Requests.Documents;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Courses
{
    public partial class frmCoursesDetails : Form
    {
        private int _courseId;
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseSection = new APIService("course-section");
        private readonly APIService _serviceDocuments = new APIService("document");
        public frmCoursesDetails(int courseId)
        {
            InitializeComponent();
            _courseId = courseId;
        }

        private async void frmCoursesDetails_Load(object sender, EventArgs e)
        {
            var list = await _serviceCourseSection.Get<List<Model.CourseSections>>(null);
            comboBoxCategory.DataSource = list;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CourseSectionId";

            var course =await _serviceCourses.GetById<Model.Courses>(_courseId);
            textBoxTitle.Text = course.CourseName;
            comboBoxCategory.SelectedValue = course.CourseSectionId;
            textBoxDescription.Text = course.Notes;
            txtPrice.Text = course.Price.ToString();
            textBoxProfessorId.Text = course.ProfessorId.ToString();
            checkBoxActive.CheckState = course.IsActive ? CheckState.Checked : CheckState.Unchecked;
            if (course.Picture != null && course.Picture.Length > 0)
                pictureBox.Image =Image.FromStream(new MemoryStream(course.Picture));

            var search = new DocumentsSearchRequest()
            {
                CourseId = course.CourseId
            };
            var document = await _serviceDocuments.Get<List<Model.Documents>>(search);
            dgvDocuments.AutoGenerateColumns = false;

            if(document != null)
            dgvDocuments.DataSource = document;

        }

        CoursesInsertRequest request = new CoursesInsertRequest();
        private async void buttonUpdate_Click(object sender, EventArgs e)
        {

            request.CourseName = textBoxTitle.Text;
            request.Notes = textBoxDescription.Text;
            request.ProfessorId = Int32.Parse(textBoxProfessorId.Text);
            request.Price = Double.Parse(txtPrice.Text);
            //request.IsActive = true;
            request.CourseSectionId = (int)comboBoxCategory.SelectedValue;
            request.Picture = request.PictureThumb != null? request.PictureThumb: imageToByteArray(pictureBox.Image);
            request.PictureThumb = request.PictureThumb != null? request.PictureThumb: imageToByteArray(pictureBox.Image);

            await _serviceCourses.Update<Model.Courses>(_courseId, request);
            MessageBox.Show("Successfully updated course.");
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await _serviceCourses.Delete<Model.Courses>(_courseId);

                frmIndex frm = (frmIndex)Application.OpenForms.Cast<Form>().Where(x => x.Name == "frmIndex").FirstOrDefault();
                frmCourses form = new frmCourses();
                if (frm != null) frm.openChildForm(form);

                MessageBox.Show("Successfully deleted course.");

            }
            else return;

        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private void uploadImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.PNG;*.JPG)";
            if(result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.PictureThumb = file;
                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
            }
            else if(result == DialogResult.Cancel)
            {
                request.PictureThumb = imageToByteArray(pictureBox.Image); 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActive.Checked)
                request.IsActive = true;
            else
                request.IsActive = false;
        }

        private async void dgvDocuments_MouseClick(object sender, MouseEventArgs e)
        {
            var id = dgvDocuments.SelectedRows[0].Cells[0].Value;
            var doc = await _serviceDocuments.GetById<Model.Documents>(int.Parse(id.ToString()));
            //WebClient webClient = new WebClient();
            //webClient.DownloadFile("~OnlineCourseApp\\OnlineCourseApp.WebAPI\\Resources/", doc.FileName);

            //var memory = new MemoryStream();
            //using (var stream = new FileStream(path, FileMode.Open))
            //{
            //    await stream.CopyToAsync(memory);
            //    stream.Close();
            //}
            //memory.Position = 0;
            //return File(memory, "application/octet-stream", doc.FileName);

        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            var result = openFileDialog2.ShowDialog();
            openFileDialog2.Filter = "Pdf documents (*.pdf)|*.pdf";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.Multiselect = false;

            if (result == DialogResult.OK)
            {
                if (openFileDialog2.CheckFileExists)
                {

                    var fileName = openFileDialog2.FileName;
                    var filee = Path.GetFileName(fileName);
                    var url = $"{Properties.Settings.Default.APIUrl}/document/upload/{_courseId}";


                    MemoryStream ms = new MemoryStream();
                    using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    {

                        fileStream.CopyTo(ms);
                        ms.Position = 0;
                     
                           var formContent = new MultipartContent();
                        formContent.Headers.ContentType.MediaType = "application/pdf";
                        formContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data") { Name = "\"file\"", FileName=$"{filee}" };

                        await url.PostMultipartAsync(mp => mp.AddFile($"{filee}", ms, fileName).Add(formContent));
                    }

                    var search = new DocumentsSearchRequest()
                    {
                        CourseId = _courseId
                    };
                    var document = await _serviceDocuments.Get<List<Model.Documents>>(search);
                    dgvDocuments.AutoGenerateColumns = false;

                    if (document != null)
                        dgvDocuments.DataSource = document;

                }
                else
                {
                    MessageBox.Show("Please upload document.");
                }


            }
        }
    }
}
