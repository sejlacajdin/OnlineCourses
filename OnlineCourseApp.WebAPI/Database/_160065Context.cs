using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OnlineCourseApp.WebAPI.Database
{
    public partial class _160065Context : DbContext
    {
        public _160065Context()
        {
        }

        public _160065Context(DbContextOptions<_160065Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<AnnouncementFilter> AnnouncementFilters { get; set; }
        public virtual DbSet<AnnouncementFilterType> AnnouncementFilterTypes { get; set; }
        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseParticipant> CourseParticipants { get; set; }
        public virtual DbSet<CourseSection> CourseSections { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentDownloaded> DocumentDownloadeds { get; set; }
        public virtual DbSet<DocumentShare> DocumentShares { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamAnsweredQuestion> ExamAnsweredQuestions { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionCategory> QuestionCategories { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=160065;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.ToTable("Announcement");

                entity.Property(e => e.AnnouncementId).HasColumnName("AnnouncementID");

                entity.Property(e => e.AnnouncementOwnerId).HasColumnName("AnnouncementOwnerID");

                entity.Property(e => e.FilterTypeId).HasColumnName("FilterTypeID");

                entity.Property(e => e.PostOwner)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AnnouncementOwner)
                    .WithMany(p => p.Announcements)
                    .HasForeignKey(d => d.AnnouncementOwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnnouncementOwner_Announcement");

                entity.HasOne(d => d.FilterType)
                    .WithMany(p => p.Announcements)
                    .HasForeignKey(d => d.FilterTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilterType_Announcement");
            });

            modelBuilder.Entity<AnnouncementFilter>(entity =>
            {
                entity.ToTable("AnnouncementFilter");

                entity.Property(e => e.AnnouncementFilterId).HasColumnName("AnnouncementFilterID");

                entity.Property(e => e.AnnouncementId).HasColumnName("AnnouncementID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseSectionId).HasColumnName("CourseSectionID");

                entity.Property(e => e.CourseTypeId).HasColumnName("CourseTypeID");

                entity.HasOne(d => d.Announcement)
                    .WithMany(p => p.AnnouncementFilters)
                    .HasForeignKey(d => d.AnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Announcement_AnnouncementFilter");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.AnnouncementFilters)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Course_AnnouncementFilter");

                entity.HasOne(d => d.CourseSection)
                    .WithMany(p => p.AnnouncementFilters)
                    .HasForeignKey(d => d.CourseSectionId)
                    .HasConstraintName("FK_CourseSection_AnnouncementFilter");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.AnnouncementFilters)
                    .HasForeignKey(d => d.CourseTypeId)
                    .HasConstraintName("FK_CourseType_AnnouncementFilter");
            });

            modelBuilder.Entity<AnnouncementFilterType>(entity =>
            {
                entity.ToTable("AnnouncementFilterType");

                entity.Property(e => e.AnnouncementFilterTypeId).HasColumnName("AnnouncementFilterTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Choice>(entity =>
            {
                entity.ToTable("Choice");

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Choices)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Choice");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CourseSectionId).HasColumnName("CourseSectionID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.ProfessorId).HasColumnName("ProfessorID");

                entity.HasOne(d => d.CourseSection)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CourseSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseSection_Course");

                entity.HasOne(d => d.Professor)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.ProfessorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Professor_Course");
            });

            modelBuilder.Entity<CourseParticipant>(entity =>
            {
                entity.ToTable("CourseParticipant");

                entity.Property(e => e.CourseParticipantId)
                    .ValueGeneratedNever()
                    .HasColumnName("CourseParticipantID");

                entity.Property(e => e.Comment).HasMaxLength(150);

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseParticipants)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_CourseParticipant");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.CourseParticipants)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_CourseParticipant");
            });

            modelBuilder.Entity<CourseSection>(entity =>
            {
                entity.ToTable("CourseSection");

                entity.Property(e => e.CourseSectionId).HasColumnName("CourseSectionID");

                entity.Property(e => e.CourseParentId).HasColumnName("CourseParentID");

                entity.Property(e => e.CourseTypeId).HasColumnName("CourseTypeID");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CourseParent)
                    .WithMany(p => p.InverseCourseParent)
                    .HasForeignKey(d => d.CourseParentId)
                    .HasConstraintName("FK_CourseParent_CourseSection");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.CourseSections)
                    .HasForeignKey(d => d.CourseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseType_CourseSection");
            });

            modelBuilder.Entity<CourseType>(entity =>
            {
                entity.ToTable("CourseType");

                entity.Property(e => e.CourseTypeId).HasColumnName("CourseTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordUpdated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentOwnerId).HasColumnName("DocumentOwnerID");

                entity.Property(e => e.FileExstension)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileOldName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.DocumentOwner)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.DocumentOwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentOwner_Document");
            });

            modelBuilder.Entity<DocumentDownloaded>(entity =>
            {
                entity.ToTable("DocumentDownloaded");

                entity.Property(e => e.DocumentDownloadedId).HasColumnName("DocumentDownloadedID");

                entity.Property(e => e.DocumentShareId).HasColumnName("DocumentShareID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.DocumentShare)
                    .WithMany(p => p.DocumentDownloadeds)
                    .HasForeignKey(d => d.DocumentShareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentShare_DocumentDownloaded");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.DocumentDownloadeds)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_DocumentDownloaded");
            });

            modelBuilder.Entity<DocumentShare>(entity =>
            {
                entity.ToTable("DocumentShare");

                entity.Property(e => e.DocumentShareId).HasColumnName("DocumentShareID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.DocumentShares)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_DocumentShare");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.DocumentShares)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_DocumentShare");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.ToTable("Exam");

                entity.Property(e => e.ExamId).HasColumnName("ExamID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.ExamOwnerId).HasColumnName("ExamOwnerID");

                entity.Property(e => e.Instructions)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_Exam");

                entity.HasOne(d => d.ExamOwner)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.ExamOwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamOwner_Exam");
            });

            modelBuilder.Entity<ExamAnsweredQuestion>(entity =>
            {
                entity.ToTable("ExamAnsweredQuestion");

                entity.Property(e => e.ExamAnsweredQuestionId).HasColumnName("ExamAnsweredQuestionID");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Choice)
                    .WithMany(p => p.ExamAnsweredQuestions)
                    .HasForeignKey(d => d.ChoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Choice_ExamAnsweredQuestion");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ExamAnsweredQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_ExamAnsweredQuestion");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ExamAnsweredQuestions)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_ExamAnsweredQuestion");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.ExamId).HasColumnName("ExamID");

                entity.Property(e => e.QuestionCategoryId).HasColumnName("QuestionCategoryID");

                entity.Property(e => e.QuestionTypeId).HasColumnName("QuestionTypeID");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_Question");

                entity.HasOne(d => d.QuestionCategory)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionCategory_Question");

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionType_Question");
            });

            modelBuilder.Entity<QuestionCategory>(entity =>
            {
                entity.ToTable("QuestionCategory");

                entity.Property(e => e.QuestionCategoryId).HasColumnName("QuestionCategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.ToTable("QuestionType");

                entity.Property(e => e.QuestionTypeId).HasColumnName("QuestionTypeID");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "CS_Email")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "CS_Username")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PasswordSalt).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.ToTable("UserLog");

                entity.Property(e => e.UserLogId).HasColumnName("UserLogID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserLog");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.UserRolesId);

                entity.Property(e => e.UserRolesId).HasColumnName("UserRolesID");

                entity.Property(e => e.RecordUpdated).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_UserRoles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserRoles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
