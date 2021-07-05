
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
            this.components = new System.ComponentModel.Container();
            this.lblChoice = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.NumericUpDown();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.textBoxChoice = new System.Windows.Forms.RichTextBox();
            this.btnSaveChoice = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.checkBoxActive.Size = new System.Drawing.Size(102, 24);
            this.checkBoxActive.TabIndex = 24;
            this.checkBoxActive.Text = "Is correct";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.checkBoxActive_CheckedChanged);
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
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(38, 254);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(427, 27);
            this.txtPercentage.TabIndex = 25;
            this.txtPercentage.Validating += new System.ComponentModel.CancelEventHandler(this.txtPercentage_Validating);
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
            // textBoxChoice
            // 
            this.textBoxChoice.Location = new System.Drawing.Point(38, 115);
            this.textBoxChoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxChoice.Name = "textBoxChoice";
            this.textBoxChoice.Size = new System.Drawing.Size(427, 92);
            this.textBoxChoice.TabIndex = 27;
            this.textBoxChoice.Text = "";
            this.textBoxChoice.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxChoice_Validating);
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
            this.btnSaveChoice.Click += new System.EventHandler(this.btnSaveChoice_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmChoiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 461);
            this.Controls.Add(this.btnSaveChoice);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.textBoxChoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.lblChoice);
            this.Name = "frmChoiceAdd";
            this.Text = "frmChoiceAdd";
            this.Load += new System.EventHandler(this.frmChoiceAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtPercentage;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.RichTextBox textBoxChoice;
        private System.Windows.Forms.Button btnSaveChoice;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}