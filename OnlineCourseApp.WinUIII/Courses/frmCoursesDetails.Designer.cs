
namespace OnlineCourseApp.WinUI.Courses
{
    partial class frmCoursesDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.uploadImage = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.textBoxProfessorId = new System.Windows.Forms.TextBox();
            this.labelDocuments = new System.Windows.Forms.Label();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.DocumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileOldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnUploadVideo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.dgvVideos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteVideo = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(39, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 149);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(335, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(335, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(335, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(335, 52);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(390, 22);
            this.textBoxTitle.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(335, 178);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(390, 95);
            this.textBoxDescription.TabIndex = 6;
            this.textBoxDescription.Text = "";
            // 
            // uploadImage
            // 
            this.uploadImage.AutoSize = true;
            this.uploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uploadImage.ForeColor = System.Drawing.Color.MediumBlue;
            this.uploadImage.Location = new System.Drawing.Point(97, 188);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(120, 18);
            this.uploadImage.TabIndex = 7;
            this.uploadImage.Text = "UPLOAD IMAGE";
            this.uploadImage.Click += new System.EventHandler(this.uploadImage_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(335, 115);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(390, 24);
            this.comboBoxCategory.TabIndex = 8;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(625, 366);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(101, 29);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(518, 366);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 29);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checkBoxActive.Location = new System.Drawing.Point(335, 343);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(149, 24);
            this.checkBoxActive.TabIndex = 11;
            this.checkBoxActive.Text = "Is course active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxProfessorId
            // 
            this.textBoxProfessorId.Enabled = false;
            this.textBoxProfessorId.Location = new System.Drawing.Point(39, 238);
            this.textBoxProfessorId.Name = "textBoxProfessorId";
            this.textBoxProfessorId.Size = new System.Drawing.Size(114, 22);
            this.textBoxProfessorId.TabIndex = 12;
            this.textBoxProfessorId.Visible = false;
            // 
            // labelDocuments
            // 
            this.labelDocuments.AutoSize = true;
            this.labelDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelDocuments.Location = new System.Drawing.Point(39, 448);
            this.labelDocuments.Name = "labelDocuments";
            this.labelDocuments.Size = new System.Drawing.Size(106, 24);
            this.labelDocuments.TabIndex = 13;
            this.labelDocuments.Text = "Documents";
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocuments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.ColumnHeadersVisible = false;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentId,
            this.FileOldName,
            this.Delete});
            this.dgvDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDocuments.Location = new System.Drawing.Point(35, 479);
            this.dgvDocuments.Margin = new System.Windows.Forms.Padding(3, 3, 23, 3);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.ReadOnly = true;
            this.dgvDocuments.RowHeadersWidth = 51;
            this.dgvDocuments.RowTemplate.Height = 25;
            this.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocuments.Size = new System.Drawing.Size(810, 135);
            this.dgvDocuments.TabIndex = 14;
            this.dgvDocuments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_CellClick);
            this.dgvDocuments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDocuments_MouseDoubleClick);
            // 
            // DocumentId
            // 
            this.DocumentId.DataPropertyName = "DocumentId";
            this.DocumentId.HeaderText = "Id";
            this.DocumentId.MinimumWidth = 6;
            this.DocumentId.Name = "DocumentId";
            this.DocumentId.ReadOnly = true;
            this.DocumentId.Visible = false;
            // 
            // FileOldName
            // 
            this.FileOldName.DataPropertyName = "FileOldName";
            this.FileOldName.FillWeight = 140.1015F;
            this.FileOldName.HeaderText = "Name";
            this.FileOldName.MinimumWidth = 6;
            this.FileOldName.Name = "FileOldName";
            this.FileOldName.ReadOnly = true;
            this.FileOldName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.FillWeight = 59.89848F;
            this.Delete.HeaderText = "Action";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(335, 307);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(157, 22);
            this.txtPrice.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(335, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(464, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "$";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(759, 449);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(86, 25);
            this.btnUpload.TabIndex = 18;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnUploadVideo
            // 
            this.btnUploadVideo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUploadVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUploadVideo.ForeColor = System.Drawing.Color.White;
            this.btnUploadVideo.Location = new System.Drawing.Point(625, 660);
            this.btnUploadVideo.Name = "btnUploadVideo";
            this.btnUploadVideo.Size = new System.Drawing.Size(86, 25);
            this.btnUploadVideo.TabIndex = 20;
            this.btnUploadVideo.Text = "UPLOAD";
            this.btnUploadVideo.UseVisualStyleBackColor = false;
            this.btnUploadVideo.Click += new System.EventHandler(this.btnUploadVideo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(39, 661);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Videos";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // dgvVideos
            // 
            this.dgvVideos.AllowUserToAddRows = false;
            this.dgvVideos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVideos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVideos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideos.ColumnHeadersVisible = false;
            this.dgvVideos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.DeleteVideo});
            this.dgvVideos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvVideos.Location = new System.Drawing.Point(39, 691);
            this.dgvVideos.Margin = new System.Windows.Forms.Padding(3, 3, 23, 3);
            this.dgvVideos.Name = "dgvVideos";
            this.dgvVideos.ReadOnly = true;
            this.dgvVideos.RowHeadersWidth = 51;
            this.dgvVideos.RowTemplate.Height = 25;
            this.dgvVideos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVideos.Size = new System.Drawing.Size(675, 135);
            this.dgvVideos.TabIndex = 21;
            this.dgvVideos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVideos_CellClick);
            this.dgvVideos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvVideos_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VideoId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 140.1015F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DeleteVideo
            // 
            this.DeleteVideo.DataPropertyName = "Delete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DeleteVideo.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteVideo.FillWeight = 59.89848F;
            this.DeleteVideo.HeaderText = "Action";
            this.DeleteVideo.MinimumWidth = 6;
            this.DeleteVideo.Name = "DeleteVideo";
            this.DeleteVideo.ReadOnly = true;
            this.DeleteVideo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteVideo.Text = "Delete";
            this.DeleteVideo.UseColumnTextForButtonValue = true;
            // 
            // frmCoursesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 882);
            this.Controls.Add(this.dgvVideos);
            this.Controls.Add(this.btnUploadVideo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDocuments);
            this.Controls.Add(this.labelDocuments);
            this.Controls.Add(this.textBoxProfessorId);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.uploadImage);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Name = "frmCoursesDetails";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.Text = "frmCoursesDetails";
            this.Load += new System.EventHandler(this.frmCoursesDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.Windows.Forms.Label uploadImage;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.TextBox textBoxProfessorId;
        private System.Windows.Forms.Label labelDocuments;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileOldName;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnUploadVideo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.DataGridView dgvVideos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteVideo;
    }
}