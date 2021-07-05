
namespace OnlineCourseApp.WinUI.Choices
{
    partial class frmChoiceAdd
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
            this.lblChoice = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.NumericUpDown();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.btnSaveChoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChoice.Location = new System.Drawing.Point(38, 34);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(165, 36);
            this.lblChoice.TabIndex = 11;
            this.lblChoice.Text = "Add choice";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxActive.Location = new System.Drawing.Point(38, 305);
            this.checkBoxActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(147, 24);
            this.checkBoxActive.TabIndex = 24;
            this.checkBoxActive.Text = "Is choice active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Percentage";
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(38, 254);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(373, 27);
            this.txtPoints.TabIndex = 25;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer.Location = new System.Drawing.Point(38, 87);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(46, 22);
            this.lblAnswer.TabIndex = 28;
            this.lblAnswer.Text = "Text";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(38, 115);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(463, 92);
            this.textBoxQuestion.TabIndex = 27;
            this.textBoxQuestion.Text = "";
            // 
            // btnSaveChoice
            // 
            this.btnSaveChoice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSaveChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChoice.ForeColor = System.Drawing.Color.White;
            this.btnSaveChoice.Location = new System.Drawing.Point(155, 365);
            this.btnSaveChoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveChoice.Name = "btnSaveChoice";
            this.btnSaveChoice.Size = new System.Drawing.Size(194, 43);
            this.btnSaveChoice.TabIndex = 29;
            this.btnSaveChoice.Text = "SAVE";
            this.btnSaveChoice.UseVisualStyleBackColor = false;
            // 
            // frmChoiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 461);
            this.Controls.Add(this.btnSaveChoice);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.lblChoice);
            this.Name = "frmChoiceAdd";
            this.Text = "frmChoiceAdd";
            ((System.ComponentModel.ISupportInitialize)(this.txtPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtPoints;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.RichTextBox textBoxQuestion;
        private System.Windows.Forms.Button btnSaveChoice;
    }
}