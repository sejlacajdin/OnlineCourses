
namespace OnlineCourseApp.WinUI.Controls
{
    partial class CardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.courseName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courseSection = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.Label();
            this.courseId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseName.Location = new System.Drawing.Point(10, 140);
            this.courseName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.courseName.MaximumSize = new System.Drawing.Size(185, 50);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(58, 25);
            this.courseName.TabIndex = 0;
            this.courseName.Text = "label1";
            this.courseName.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // courseSection
            // 
            this.courseSection.AutoSize = true;
            this.courseSection.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseSection.Location = new System.Drawing.Point(10, 181);
            this.courseSection.Name = "courseSection";
            this.courseSection.Size = new System.Drawing.Size(70, 14);
            this.courseSection.TabIndex = 2;
            this.courseSection.Text = "label14343";
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(10, 209);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(38, 15);
            this.notes.TabIndex = 3;
            this.notes.Text = "label1";
            // 
            // courseId
            // 
            this.courseId.AutoSize = true;
            this.courseId.Location = new System.Drawing.Point(124, 265);
            this.courseId.Name = "courseId";
            this.courseId.Size = new System.Drawing.Size(38, 15);
            this.courseId.TabIndex = 4;
            this.courseId.Text = "label1";
            this.courseId.Visible = false;
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.courseId);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.courseSection);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.courseName);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(194, 315);
            this.Click += new System.EventHandler(this.CardControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label courseSection;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.Label courseId;
    }
}
