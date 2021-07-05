
namespace OnlineCourseApp.WinUI.Questions
{
    partial class frmQuestionAdd
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.cmbQuestionCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbQuestionType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(50, 362);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(82, 22);
            this.lblQuestion.TabIndex = 12;
            this.lblQuestion.Text = "Question";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(50, 390);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(373, 139);
            this.textBoxQuestion.TabIndex = 11;
            this.textBoxQuestion.Text = "";
            this.textBoxQuestion.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxQuestion_Validating);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuestion.Location = new System.Drawing.Point(50, 38);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(192, 36);
            this.labelQuestion.TabIndex = 10;
            this.labelQuestion.Text = "Add question";
            // 
            // cmbQuestionCategory
            // 
            this.cmbQuestionCategory.FormattingEnabled = true;
            this.cmbQuestionCategory.Location = new System.Drawing.Point(50, 127);
            this.cmbQuestionCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbQuestionCategory.Name = "cmbQuestionCategory";
            this.cmbQuestionCategory.Size = new System.Drawing.Size(373, 28);
            this.cmbQuestionCategory.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Category";
            // 
            // cmbQuestionType
            // 
            this.cmbQuestionType.FormattingEnabled = true;
            this.cmbQuestionType.Location = new System.Drawing.Point(50, 198);
            this.cmbQuestionType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbQuestionType.Name = "cmbQuestionType";
            this.cmbQuestionType.Size = new System.Drawing.Size(373, 28);
            this.cmbQuestionType.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Type";
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(50, 270);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(373, 27);
            this.txtPoints.TabIndex = 18;
            this.txtPoints.Validating += new System.ComponentModel.CancelEventHandler(this.txtPoints_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Points";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxActive.Location = new System.Drawing.Point(50, 321);
            this.checkBoxActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(161, 24);
            this.checkBoxActive.TabIndex = 23;
            this.checkBoxActive.Text = "Is question active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.checkBoxActive_CheckedChanged);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestion.Location = new System.Drawing.Point(135, 584);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(194, 43);
            this.btnAddQuestion.TabIndex = 24;
            this.btnAddQuestion.Text = "SAVE";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmQuestionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 673);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.cmbQuestionType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbQuestionCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelQuestion);
            this.Name = "frmQuestionAdd";
            this.Text = "frmQuestionAdd";
            this.Load += new System.EventHandler(this.frmQuestionAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RichTextBox textBoxQuestion;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.ComboBox cmbQuestionCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbQuestionType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}