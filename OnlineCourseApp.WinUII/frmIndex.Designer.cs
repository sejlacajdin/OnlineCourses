﻿
namespace OnlineCourseApp.WinUI
{
    partial class frmIndex
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
            this.searchStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTests = new System.Windows.Forms.Button();
            this.btnAnnouncement = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchStripMenuItem
            // 
            this.searchStripMenuItem.Name = "searchStripMenuItem";
            this.searchStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.searchStripMenuItem.Text = "Search";
            // 
            // addNewStripMenuItem
            // 
            this.addNewStripMenuItem.Name = "addNewStripMenuItem";
            this.addNewStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addNewStripMenuItem.Text = "Add new user";
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.White;
            this.panelTopMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1010, 61);
            this.panelTopMenu.TabIndex = 5;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.White;
            this.panelSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSideMenu.Controls.Add(this.btnReports);
            this.panelSideMenu.Controls.Add(this.btnTests);
            this.panelSideMenu.Controls.Add(this.btnAnnouncement);
            this.panelSideMenu.Controls.Add(this.btnCourses);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 61);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(237, 534);
            this.panelSideMenu.TabIndex = 6;
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReports.Location = new System.Drawing.Point(0, 144);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(235, 48);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnTests
            // 
            this.btnTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTests.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTests.Location = new System.Drawing.Point(0, 96);
            this.btnTests.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btnTests.Name = "btnTests";
            this.btnTests.Size = new System.Drawing.Size(235, 48);
            this.btnTests.TabIndex = 2;
            this.btnTests.Text = "Tests";
            this.btnTests.UseVisualStyleBackColor = true;
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnouncement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnouncement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnnouncement.Location = new System.Drawing.Point(0, 48);
            this.btnAnnouncement.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(235, 48);
            this.btnAnnouncement.TabIndex = 1;
            this.btnAnnouncement.Text = "Announcements";
            this.btnAnnouncement.UseVisualStyleBackColor = true;
            // 
            // btnCourses
            // 
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCourses.Location = new System.Drawing.Point(0, 0);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(235, 48);
            this.btnCourses.TabIndex = 0;
            this.btnCourses.Text = "My Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Location = new System.Drawing.Point(237, 61);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(773, 534);
            this.panelChildForm.TabIndex = 8;
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 595);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelTopMenu);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolStripMenuItem searchStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStripMenuItem;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.Button btnAnnouncement;
    }
}



