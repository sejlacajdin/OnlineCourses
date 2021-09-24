using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineCourseApp.WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnnouncementFilterType",
                columns: table => new
                {
                    AnnouncementFilterTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementFilterType", x => x.AnnouncementFilterTypeID);
                });

            migrationBuilder.CreateTable(
                name: "CourseType",
                columns: table => new
                {
                    CourseTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RecordUpdated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseType", x => x.CourseTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileExstension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileOldName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentID);
                });

            migrationBuilder.CreateTable(
                name: "QuestionCategory",
                columns: table => new
                {
                    QuestionCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionCategory", x => x.QuestionCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "QuestionType",
                columns: table => new
                {
                    QuestionTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionType", x => x.QuestionTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "CourseSection",
                columns: table => new
                {
                    CourseSectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CourseTypeID = table.Column<int>(type: "int", nullable: false),
                    CourseParentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSection", x => x.CourseSectionID);
                    table.ForeignKey(
                        name: "FK_CourseParent_CourseSection",
                        column: x => x.CourseParentID,
                        principalTable: "CourseSection",
                        principalColumn: "CourseSectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseType_CourseSection",
                        column: x => x.CourseTypeID,
                        principalTable: "CourseType",
                        principalColumn: "CourseTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Announcement",
                columns: table => new
                {
                    AnnouncementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnouncementOwnerID = table.Column<int>(type: "int", nullable: false),
                    FilterTypeID = table.Column<int>(type: "int", nullable: false),
                    PostOwner = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement", x => x.AnnouncementID);
                    table.ForeignKey(
                        name: "FK_AnnouncementOwner_Announcement",
                        column: x => x.AnnouncementOwnerID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilterType_Announcement",
                        column: x => x.FilterTypeID,
                        principalTable: "AnnouncementFilterType",
                        principalColumn: "AnnouncementFilterTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLog",
                columns: table => new
                {
                    UserLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLog", x => x.UserLogID);
                    table.ForeignKey(
                        name: "FK_User_UserLog",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRolesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    RecordUpdated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRolesID);
                    table.ForeignKey(
                        name: "FK_Role_UserRoles",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserRoles",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ProfessorID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CourseSectionID = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PictureThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    NumOfRatings = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_CourseSection_Course",
                        column: x => x.CourseSectionID,
                        principalTable: "CourseSection",
                        principalColumn: "CourseSectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Professor_Course",
                        column: x => x.ProfessorID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementFilter",
                columns: table => new
                {
                    AnnouncementFilterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementID = table.Column<int>(type: "int", nullable: false),
                    CourseTypeID = table.Column<int>(type: "int", nullable: true),
                    CourseSectionID = table.Column<int>(type: "int", nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementFilter", x => x.AnnouncementFilterID);
                    table.ForeignKey(
                        name: "FK_Announcement_AnnouncementFilter",
                        column: x => x.AnnouncementID,
                        principalTable: "Announcement",
                        principalColumn: "AnnouncementID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Course_AnnouncementFilter",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseSection_AnnouncementFilter",
                        column: x => x.CourseSectionID,
                        principalTable: "CourseSection",
                        principalColumn: "CourseSectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseType_AnnouncementFilter",
                        column: x => x.CourseTypeID,
                        principalTable: "CourseType",
                        principalColumn: "CourseTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseParticipant",
                columns: table => new
                {
                    CourseParticipantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Review = table.Column<int>(type: "int", nullable: false),
                    ParticipationDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseParticipant", x => x.CourseParticipantID);
                    table.ForeignKey(
                        name: "FK_Course_CourseParticipant",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_CourseParticipant",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentShare",
                columns: table => new
                {
                    DocumentShareID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentShare", x => x.DocumentShareID);
                    table.ForeignKey(
                        name: "FK_Course_DocumentShare",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Document_DocumentShare",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    ExamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    TimeLimit = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    ExamOwnerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.ExamID);
                    table.ForeignKey(
                        name: "FK_Course_Exam",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamOwner_Exam",
                        column: x => x.ExamOwnerID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    VideoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Size = table.Column<long>(type: "bigint", nullable: true),
                    File = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.VideoID);
                    table.ForeignKey(
                        name: "FK_Video_Course",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentDownloaded",
                columns: table => new
                {
                    DocumentDownloadedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentShareID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentDownloaded", x => x.DocumentDownloadedID);
                    table.ForeignKey(
                        name: "FK_DocumentShare_DocumentDownloaded",
                        column: x => x.DocumentShareID,
                        principalTable: "DocumentShare",
                        principalColumn: "DocumentShareID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_DocumentDownloaded",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionCategoryID = table.Column<int>(type: "int", nullable: false),
                    QuestionTypeID = table.Column<int>(type: "int", nullable: false),
                    ExamID = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    QuestionNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_Exam_Question",
                        column: x => x.ExamID,
                        principalTable: "Exam",
                        principalColumn: "ExamID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionCategory_Question",
                        column: x => x.QuestionCategoryID,
                        principalTable: "QuestionCategory",
                        principalColumn: "QuestionCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionType_Question",
                        column: x => x.QuestionTypeID,
                        principalTable: "QuestionType",
                        principalColumn: "QuestionTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Choice",
                columns: table => new
                {
                    ChoiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionID = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Percentage = table.Column<double>(type: "float", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choice", x => x.ChoiceID);
                    table.ForeignKey(
                        name: "FK_Question_Choice",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamAnsweredQuestion",
                columns: table => new
                {
                    ExamAnsweredQuestionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    QuestionID = table.Column<int>(type: "int", nullable: false),
                    ChoiceID = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MarkScored = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamAnsweredQuestion", x => x.ExamAnsweredQuestionID);
                    table.ForeignKey(
                        name: "FK_Choice_ExamAnsweredQuestion",
                        column: x => x.ChoiceID,
                        principalTable: "Choice",
                        principalColumn: "ChoiceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Question_ExamAnsweredQuestion",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_ExamAnsweredQuestion",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcement_AnnouncementOwnerID",
                table: "Announcement",
                column: "AnnouncementOwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Announcement_FilterTypeID",
                table: "Announcement",
                column: "FilterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementFilter_AnnouncementID",
                table: "AnnouncementFilter",
                column: "AnnouncementID");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementFilter_CourseID",
                table: "AnnouncementFilter",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementFilter_CourseSectionID",
                table: "AnnouncementFilter",
                column: "CourseSectionID");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementFilter_CourseTypeID",
                table: "AnnouncementFilter",
                column: "CourseTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Choice_QuestionID",
                table: "Choice",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CourseSectionID",
                table: "Course",
                column: "CourseSectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ProfessorID",
                table: "Course",
                column: "ProfessorID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseParticipant_CourseID",
                table: "CourseParticipant",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseParticipant_StudentID",
                table: "CourseParticipant",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSection_CourseParentID",
                table: "CourseSection",
                column: "CourseParentID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSection_CourseTypeID",
                table: "CourseSection",
                column: "CourseTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentDownloaded_DocumentShareID",
                table: "DocumentDownloaded",
                column: "DocumentShareID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentDownloaded_StudentID",
                table: "DocumentDownloaded",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentShare_CourseID",
                table: "DocumentShare",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentShare_DocumentID",
                table: "DocumentShare",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_CourseID",
                table: "Exam",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_ExamOwnerID",
                table: "Exam",
                column: "ExamOwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAnsweredQuestion_ChoiceID",
                table: "ExamAnsweredQuestion",
                column: "ChoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAnsweredQuestion_QuestionID",
                table: "ExamAnsweredQuestion",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAnsweredQuestion_StudentID",
                table: "ExamAnsweredQuestion",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Question_ExamID",
                table: "Question",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuestionCategoryID",
                table: "Question",
                column: "QuestionCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuestionTypeID",
                table: "Question",
                column: "QuestionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserLog_UserID",
                table: "UserLog",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRoles",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "CS_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "CS_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Video_CourseID",
                table: "Video",
                column: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnnouncementFilter");

            migrationBuilder.DropTable(
                name: "CourseParticipant");

            migrationBuilder.DropTable(
                name: "DocumentDownloaded");

            migrationBuilder.DropTable(
                name: "ExamAnsweredQuestion");

            migrationBuilder.DropTable(
                name: "UserLog");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Announcement");

            migrationBuilder.DropTable(
                name: "DocumentShare");

            migrationBuilder.DropTable(
                name: "Choice");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "AnnouncementFilterType");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "QuestionCategory");

            migrationBuilder.DropTable(
                name: "QuestionType");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "CourseSection");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CourseType");
        }
    }
}
