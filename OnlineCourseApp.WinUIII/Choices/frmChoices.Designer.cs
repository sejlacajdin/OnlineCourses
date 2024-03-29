﻿
namespace OnlineCourseApp.WinUI.Choices
{
    partial class frmChoices
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
            this.btnAddChoice = new System.Windows.Forms.Button();
            this.dgvChoices = new System.Windows.Forms.DataGridView();
            this.ChoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCorrect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddChoice
            // 
            this.btnAddChoice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddChoice.ForeColor = System.Drawing.Color.White;
            this.btnAddChoice.Location = new System.Drawing.Point(661, 33);
            this.btnAddChoice.Name = "btnAddChoice";
            this.btnAddChoice.Size = new System.Drawing.Size(194, 34);
            this.btnAddChoice.TabIndex = 30;
            this.btnAddChoice.Text = "ADD CHOICE";
            this.btnAddChoice.UseVisualStyleBackColor = false;
            this.btnAddChoice.Click += new System.EventHandler(this.btnAddChoice_Click);
            // 
            // dgvChoices
            // 
            this.dgvChoices.AllowUserToAddRows = false;
            this.dgvChoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChoices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChoiceId,
            this.Text,
            this.Percentage,
            this.IsCorrect,
            this.Update,
            this.Delete});
            this.dgvChoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvChoices.Location = new System.Drawing.Point(33, 86);
            this.dgvChoices.Margin = new System.Windows.Forms.Padding(3, 3, 23, 3);
            this.dgvChoices.Name = "dgvChoices";
            this.dgvChoices.RowHeadersWidth = 51;
            this.dgvChoices.RowTemplate.Height = 25;
            this.dgvChoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChoices.Size = new System.Drawing.Size(817, 245);
            this.dgvChoices.TabIndex = 31;
            this.dgvChoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChoices_CellClick);
            // 
            // ChoiceId
            // 
            this.ChoiceId.DataPropertyName = "ChoiceId";
            this.ChoiceId.HeaderText = "Id";
            this.ChoiceId.MinimumWidth = 6;
            this.ChoiceId.Name = "ChoiceId";
            this.ChoiceId.Visible = false;
            this.ChoiceId.Width = 20;
            // 
            // Text
            // 
            this.Text.DataPropertyName = "Text";
            this.Text.FillWeight = 435.8288F;
            this.Text.HeaderText = "Text";
            this.Text.MinimumWidth = 6;
            this.Text.Name = "Text";
            this.Text.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Text.Width = 403;
            // 
            // Percentage
            // 
            this.Percentage.DataPropertyName = "Percentage";
            this.Percentage.FillWeight = 17.83035F;
            this.Percentage.HeaderText = "Percentage";
            this.Percentage.MinimumWidth = 6;
            this.Percentage.Name = "Percentage";
            this.Percentage.Width = 120;
            // 
            // IsCorrect
            // 
            this.IsCorrect.DataPropertyName = "IsCorrect";
            this.IsCorrect.FillWeight = 17.83035F;
            this.IsCorrect.HeaderText = "Correct";
            this.IsCorrect.MinimumWidth = 6;
            this.IsCorrect.Name = "IsCorrect";
            this.IsCorrect.Width = 60;
            // 
            // Update
            // 
            this.Update.DataPropertyName = "Update";
            this.Update.FillWeight = 17.83035F;
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 90;
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
            this.Delete.FillWeight = 10.68011F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 90;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(384, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 26);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.Location = new System.Drawing.Point(33, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(475, 22);
            this.txtSearch.TabIndex = 33;
            // 
            // frmChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 360);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvChoices);
            this.Controls.Add(this.btnAddChoice);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChoices";
            this.Load += new System.EventHandler(this.frmChoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddChoice;
        private System.Windows.Forms.DataGridView dgvChoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCorrect;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}