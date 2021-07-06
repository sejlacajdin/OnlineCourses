
namespace OnlineCourseApp.WinUI.Announcements
{
    partial class frmAnnouncementAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAnnouncement = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxShortDesc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCourseType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCourseSection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.buttonAddAnnouncement = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.AutoSize = true;
            this.lblAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncement.Location = new System.Drawing.Point(37, 44);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(274, 36);
            this.lblAnnouncement.TabIndex = 2;
            this.lblAnnouncement.Text = "Add announcement";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(37, 102);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(49, 25);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(37, 130);
            this.textTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(399, 27);
            this.textTitle.TabIndex = 3;
            this.textTitle.Validating += new System.ComponentModel.CancelEventHandler(this.textTitle_Validating);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilter.Location = new System.Drawing.Point(37, 177);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(54, 25);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(37, 205);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(399, 28);
            this.cmbFilter.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(37, 622);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(109, 25);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(37, 650);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(399, 140);
            this.textBoxDescription.TabIndex = 8;
            this.textBoxDescription.Text = "";
            this.textBoxDescription.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescription_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Short description";
            // 
            // txtBoxShortDesc
            // 
            this.txtBoxShortDesc.Location = new System.Drawing.Point(37, 525);
            this.txtBoxShortDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxShortDesc.Name = "txtBoxShortDesc";
            this.txtBoxShortDesc.Size = new System.Drawing.Size(399, 75);
            this.txtBoxShortDesc.TabIndex = 10;
            this.txtBoxShortDesc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Course type";
            // 
            // cmbCourseType
            // 
            this.cmbCourseType.FormattingEnabled = true;
            this.cmbCourseType.Location = new System.Drawing.Point(37, 284);
            this.cmbCourseType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCourseType.Name = "cmbCourseType";
            this.cmbCourseType.Size = new System.Drawing.Size(399, 28);
            this.cmbCourseType.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Course section";
            // 
            // cmbCourseSection
            // 
            this.cmbCourseSection.FormattingEnabled = true;
            this.cmbCourseSection.Location = new System.Drawing.Point(37, 363);
            this.cmbCourseSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCourseSection.Name = "cmbCourseSection";
            this.cmbCourseSection.Size = new System.Drawing.Size(399, 28);
            this.cmbCourseSection.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Course";
            // 
            // cmbCourses
            // 
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(37, 443);
            this.cmbCourses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(399, 28);
            this.cmbCourses.TabIndex = 16;
            // 
            // buttonAddAnnouncement
            // 
            this.buttonAddAnnouncement.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAddAnnouncement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddAnnouncement.ForeColor = System.Drawing.Color.White;
            this.buttonAddAnnouncement.Location = new System.Drawing.Point(129, 844);
            this.buttonAddAnnouncement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddAnnouncement.Name = "buttonAddAnnouncement";
            this.buttonAddAnnouncement.Size = new System.Drawing.Size(194, 43);
            this.buttonAddAnnouncement.TabIndex = 18;
            this.buttonAddAnnouncement.Text = "SAVE";
            this.buttonAddAnnouncement.UseVisualStyleBackColor = false;
            this.buttonAddAnnouncement.Click += new System.EventHandler(this.buttonAddAnnouncement_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAnnouncementAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 925);
            this.Controls.Add(this.buttonAddAnnouncement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCourseSection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCourseType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxShortDesc);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.lblAnnouncement);
            this.Name = "frmAnnouncementAdd";
            this.Text = "frmAnnouncementAdd";
            this.Load += new System.EventHandler(this.frmAnnouncementAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnnouncement;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtBoxShortDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCourseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCourseSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Button buttonAddAnnouncement;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}