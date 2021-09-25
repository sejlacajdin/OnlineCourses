using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Model;
using OnlineCourseApp.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI
{
    public class SetupService
    {
        public void Init(_160065Context context)
        {
            context.Database.Migrate();

            //add data
            if (!context.Roles.Any(x => x.Name == "Professor"))
            {
                context.Roles.Add(new Role() { Name = "Professor", Description = "" });
                context.SaveChanges();
                context.Roles.Add(new Role() { Name = "Student", Description = "" });
                context.SaveChanges();

            }

            if (!context.Users.Any(x => x.Username == "desktop"))
            {
                context.Users.Add(new User() { 
                    FirstName = "desktop",
                    LastName = "desktop",
                    Username = "desktop",
                    Email = "desktop@gmail.com",
                    Phone = "061222333",
                    PasswordSalt = "xskxxtOXjzmSVtvfH6EA6A==",
                    PasswordHash = "YkLK8HhTVdGM6bNiVLF5tzoxZSg=",
                    Status = true,

                });
                context.SaveChanges();
                context.Users.Add(new User() {
                    FirstName = "mobile",
                    LastName = "mobile",
                    Username = "mobile",
                    Email = "mobile@gmail.com",
                    Phone = "061333444",
                    PasswordSalt = "h7ufWqecVC1v2DHgesD4cA==",
                    PasswordHash = "qalwlbBliQD1ObV1s/f0btZYdW8=",
                    Status = true,
                });
                context.SaveChanges();

                context.Users.Add(new User()
                {
                    FirstName = "Brad",
                    LastName = "Gibson",
                    Username = "brad",
                    Email = "brad@gmail.com",
                    Phone = "061333444",
                    PasswordSalt = "h7ufWqecVC1v2DHgesD4cA==",
                    PasswordHash = "qalwlbBliQD1ObV1s/f0btZYdW8=",
                    Status = true,
                });
                context.SaveChanges();

                context.Users.Add(new User()
                {
                    FirstName = "Glen",
                    LastName = "Hart",
                    Username = "glen",
                    Email = "glen@gmail.com",
                    Phone = "061333444",
                    PasswordSalt = "h7ufWqecVC1v2DHgesD4cA==",
                    PasswordHash = "qalwlbBliQD1ObV1s/f0btZYdW8=",
                    Status = true,
                });
                context.SaveChanges();

                context.Users.Add(new User()
                {
                    FirstName = "Evan",
                    LastName = "Gardner",
                    Username = "evan",
                    Email = "evan@gmail.com",
                    Phone = "061333444",
                    PasswordSalt = "h7ufWqecVC1v2DHgesD4cA==",
                    PasswordHash = "qalwlbBliQD1ObV1s/f0btZYdW8=",
                    Status = true,
                });
                context.SaveChanges();

                context.Users.Add(new User()
                {
                    FirstName = "Nathan",
                    LastName = "Bradley",
                    Username = "nathan",
                    Email = "nathan@gmail.com",
                    Phone = "061333444",
                    PasswordSalt = "h7ufWqecVC1v2DHgesD4cA==",
                    PasswordHash = "qalwlbBliQD1ObV1s/f0btZYdW8=",
                    Status = true,
                });
                context.SaveChanges();

                context.Users.Add(new User()
                {
                    FirstName = "Tonya",
                    LastName = "Eodgers",
                    Username = "tonya",
                    Email = "tonya@gmail.com",
                    Phone = "061333444",
                    PasswordSalt = "h7ufWqecVC1v2DHgesD4cA==",
                    PasswordHash = "qalwlbBliQD1ObV1s/f0btZYdW8=",
                    Status = true,
                });
                context.SaveChanges();

                context.Users.Add(new User()
                {
                    FirstName = "Alma",
                    LastName = "Washington",
                    Username = "alma",
                    Email = "alma@gmail.com",
                    Phone = "061333444",
                    PasswordSalt = "h7ufWqecVC1v2DHgesD4cA==",
                    PasswordHash = "qalwlbBliQD1ObV1s/f0btZYdW8=",
                    Status = true,
                });
                context.SaveChanges();

            }
            if (!context.UserRoles.Any(x => x.RoleId == 1))
            {
                context.UserRoles.Add(new UserRole()
                {
                  UserId = 1,
                  RoleId = 1,
                  RecordUpdated = DateTime.Now

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserId = 2,
                    RoleId = 2,
                    RecordUpdated = DateTime.Now

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserId = 3,
                    RoleId = 1,
                    RecordUpdated = DateTime.Now

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserId = 4,
                    RoleId = 1,
                    RecordUpdated = DateTime.Now

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserId = 5,
                    RoleId = 1,
                    RecordUpdated = DateTime.Now

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserId = 6,
                    RoleId = 2,
                    RecordUpdated = DateTime.Now

                });
                context.SaveChanges();
                context.UserRoles.Add(new UserRole()
                {
                    UserId = 7,
                    RoleId = 2,
                    RecordUpdated = DateTime.Now

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserId = 8,
                    RoleId = 2,
                    RecordUpdated = DateTime.Now

                });
                context.SaveChanges();
            }

            if (!context.QuestionTypes.Any(x => x.TypeName == "MCMA"))
            {
                context.QuestionTypes.Add(new QuestionType() { TypeName = "MCMA" });
                context.SaveChanges();

                context.QuestionTypes.Add(new QuestionType() { TypeName = "MCSA" });
                context.SaveChanges();
            }

            if (!context.QuestionCategories.Any(x => x.CategoryName == "Basic"))
            {
                context.QuestionCategories.Add(new QuestionCategory() { CategoryName = "Basic"});
                context.SaveChanges();

                context.QuestionCategories.Add(new QuestionCategory() { CategoryName = "Medium" });
                context.SaveChanges();

                context.QuestionCategories.Add(new QuestionCategory() { CategoryName = "Hard" });
                context.SaveChanges();
            }

            if (!context.CourseTypes.Any(x => x.Name == "Development"))
            {
                context.CourseTypes.Add(new CourseType()
                {
                     Name = "Development",
                     RecordUpdated = DateTime.Now
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    Name = "Business",
                    RecordUpdated = DateTime.Now
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    Name = "Finance & Accounting",
                    RecordUpdated = DateTime.Now
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    Name = "IT & Software",
                    RecordUpdated = DateTime.Now
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    Name = "Design",
                    RecordUpdated = DateTime.Now
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    Name = "Marketing",
                    RecordUpdated = DateTime.Now
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    Name = "Music",
                    RecordUpdated = DateTime.Now
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    Name = "Lifestyle",
                    RecordUpdated = DateTime.Now
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    Name = "Photography & Video",
                    RecordUpdated = DateTime.Now
                });
                context.SaveChanges();
            }

            if (!context.CourseSections.Any(x => x.Name == "Web Development"))
            {
                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Web Development",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Data Science",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Mobile Development",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Game Development",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "JavaScript",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = 1
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "React",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = 1
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Entrepreneurship",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Communication",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Management",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Sales",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Media",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Business Law",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Compliance",
                    Description = "",
                    CourseTypeId = 3,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Economics",
                    Description = "",
                    CourseTypeId = 3,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Finance",
                    Description = "",
                    CourseTypeId = 3,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Taxes",
                    Description = "",
                    CourseTypeId = 3,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Network & Security",
                    Description = "",
                    CourseTypeId = 4,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Hardware",
                    Description = "",
                    CourseTypeId = 4,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Web Design",
                    Description = "",
                    CourseTypeId = 5,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Design Tools",
                    Description = "",
                    CourseTypeId = 5,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Game Design",
                    Description = "",
                    CourseTypeId = 5,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Digital Marketing",
                    Description = "",
                    CourseTypeId = 6,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Branding",
                    Description = "",
                    CourseTypeId = 6,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Public Relations",
                    Description = "",
                    CourseTypeId = 6,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Instruments",
                    Description = "",
                    CourseTypeId = 7,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Music Techniques",
                    Description = "",
                    CourseTypeId = 7,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Arts & Crafts",
                    Description = "",
                    CourseTypeId = 8,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Food & Beverage",
                    Description = "",
                    CourseTypeId = 8,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Digital Photography",
                    Description = "",
                    CourseTypeId = 9,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    Name = "Video Design",
                    Description = "",
                    CourseTypeId = 9,
                    CourseParentId = null
                });
                context.SaveChanges();
            }

            if (!context.AnnouncementFilterTypes.Any(x => x.Name == "All users"))
            {
                context.AnnouncementFilterTypes.Add(new AnnouncementFilterType() {  Name = "All users" });
                context.SaveChanges();

                context.AnnouncementFilterTypes.Add(new AnnouncementFilterType() { Name = "Professors"  });
                context.SaveChanges();

                context.AnnouncementFilterTypes.Add(new AnnouncementFilterType() {  Name = "Students" });
                context.SaveChanges();
            }

            if (!context.Courses.Any(x => x.CourseName == "The Complete JavaScript Course 2021"))
            {
                context.Courses.Add(new Course()
                {
                   CourseName = "The Complete JavaScript Course 2021",
                   Notes = "The modern JavaScript course for everyone! Master JavaScript with projects, challenges and theory. Many courses in one!",
                   ProfessorId = 1,
                   IsActive = true,
                   CourseSectionId = 1,
                   Picture = File.ReadAllBytes("Images/course1.png"),
                   PictureThumb = File.ReadAllBytes("Images/course1.png"),
                   Rating = 4,
                   NumOfRatings = 1,
                   Price = 35
                });
                context.SaveChanges();

                context.Courses.Add(new Course()
                {
                    CourseName = "Angular - The Complete Guide",
                    Notes = "Master Angular 12 and build awesome, reactive web apps with the successor of Angular.js",
                    ProfessorId = 1,
                    IsActive = true,
                    CourseSectionId = 1,
                    Picture = File.ReadAllBytes("Images/course1.png"),
                    PictureThumb = File.ReadAllBytes("Images/course1.png"),
                    Rating = 20,
                    NumOfRatings = 5,
                    Price = 65
                });
                context.SaveChanges();

                context.Courses.Add(new Course()
                {
                    CourseName = "Machine Learning A-Z™: Hands-On Python & R In Data Science",
                    Notes = "Learn to create Machine Learning Algorithms in Python and R from two Data Science experts. Code templates included.",
                    ProfessorId = 3,
                    IsActive = true,
                    CourseSectionId = 2,
                    Picture = File.ReadAllBytes("Images/course2.jpg"),
                    PictureThumb = File.ReadAllBytes("Images/course2.jpg"),
                    Rating = 40,
                    NumOfRatings = 8,
                    Price = 90
                });
                context.SaveChanges();

                context.Courses.Add(new Course()
                {
                    CourseName = "Complete C# Unity Game Developer 2D",
                    Notes = "Learn Unity in C# & Code Your First Seven 2D Video Games for Web, Mac & PC. The Tutorials Cover Tilemap (35 hours)",
                    ProfessorId = 4,
                    IsActive = true,
                    CourseSectionId = 4,
                    Picture = File.ReadAllBytes("Images/course2.jpg"),
                    PictureThumb = File.ReadAllBytes("Images/course2.jpg"),
                    Rating = 150,
                    NumOfRatings = 8,
                    Price = 199
                });
                context.SaveChanges();

                context.Courses.Add(new Course()
                {
                    CourseName = "An Entire MBA in 1 Course:Award Winning Business School Prof",
                    Notes = "** #1 Best Selling Business Course! ** Everything You Need to Know About Business from Start-up to IPO",
                    ProfessorId = 5,
                    IsActive = true,
                    CourseSectionId = 7,
                    Picture = File.ReadAllBytes("Images/course2.jpg"),
                    PictureThumb = File.ReadAllBytes("Images/course2.jpg"),
                    Rating = 150,
                    NumOfRatings = 8,
                    Price = 20
                });
                context.SaveChanges();

                context.Courses.Add(new Course()
                {
                    CourseName = "Become a Product Manager | Learn the Skills & Get the Job",
                    Notes = "The most complete course available on Product Management. 13+ hours of videos, activities, interviews, & more",
                    ProfessorId = 1,
                    IsActive = true,
                    CourseSectionId = 9,
                    Picture = File.ReadAllBytes("Images/course2.jpg"),
                    PictureThumb = File.ReadAllBytes("Images/course2.jpg"),
                    Rating = 200,
                    NumOfRatings = 40,
                    Price = 65
                });
                context.SaveChanges();

                context.Courses.Add(new Course()
                {
                    CourseName = "How To Become a Bestselling Author on Amazon Kindle",
                    Notes = "Learn how to make money writing with this complete guide to writing, formatting, publishing and marketing Kindle ebooks",
                    ProfessorId = 1,
                    IsActive = true,
                    CourseSectionId = 11,
                    Picture = File.ReadAllBytes("Images/course3.png"),
                    PictureThumb = File.ReadAllBytes("Images/course3.png"),
                    Rating = 29,
                    NumOfRatings = 15,
                    Price = 65
                });
                context.SaveChanges();

                context.Courses.Add(new Course()
                {
                    CourseName = "Wordpress for Beginners - Master Wordpress Quickly",
                    Notes = "In 2020, build a beautiful responsive Wordpress site that looks great on all devices. No experience required.",
                    ProfessorId = 1,
                    IsActive = true,
                    CourseSectionId = 19,
                    Picture = File.ReadAllBytes("Images/course1.png"),
                    PictureThumb = File.ReadAllBytes("Images/course1.png"),
                    Rating = 29,
                    NumOfRatings = 15,
                    Price = 65
                });
                context.SaveChanges();

                context.Courses.Add(new Course()
                {
                    CourseName = "Pianoforall - Incredible New Way To Learn Piano & Keyboard",
                    Notes = "Learn Piano in WEEKS not years. Play-By-Ear & learn to Read Music. Pop, Blues, Jazz, Ballads, Improvisation, Classical",
                    ProfessorId = 3,
                    IsActive = true,
                    CourseSectionId = 25,
                    Picture = File.ReadAllBytes("Images/course1.png"),
                    PictureThumb = File.ReadAllBytes("Images/course1.png"),
                    Rating = 58,
                    NumOfRatings = 30,
                    Price = 50
                });
                context.SaveChanges();
            }

            if (!context.CourseParticipants.Any(x => x.CourseParticipantId == 1))
            {
                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 2,
                    CourseId = 1,
                    Comment = "Neki komentar za kurs",
                    Review = 3,
                    ParticipationDate = DateTime.Now
                }); 
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 2,
                    CourseId = 2,
                    Review = 4,
                    ParticipationDate = DateTime.Now
                }); 
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 2,
                    CourseId = 3,
                    Review = 5,
                    ParticipationDate = DateTime.Now
                }); 
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 2,
                    CourseId = 5,
                    Review = 5,
                    ParticipationDate = DateTime.Now
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 6,
                    CourseId = 3,
                    Review = 5,
                    ParticipationDate = DateTime.Now
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 6,
                    CourseId = 1,
                    Review = 2,
                    ParticipationDate = DateTime.Now
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 6,
                    CourseId = 2,
                    Review = 3,
                    ParticipationDate = DateTime.Now
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 7,
                    CourseId = 1,
                    Review = 2,
                    ParticipationDate = DateTime.Now
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 7,
                    CourseId = 2,
                    Review = 3,
                    ParticipationDate = DateTime.Now
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 7,
                    CourseId = 6,
                    Review = 3,
                    ParticipationDate = DateTime.Now
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 8,
                    CourseId = 6,
                    Review = 4,
                    ParticipationDate = DateTime.Now
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 8,
                    CourseId = 1,
                    Review = 4,
                    ParticipationDate = DateTime.Now
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    StudentId = 8,
                    CourseId = 3,
                    Review = 4,
                    ParticipationDate = DateTime.Now
                });
                context.SaveChanges();
            }

            if (!context.Exams.Any(x => x.Title == "JavaScript exam entry level"))
            {
                context.Exams.Add(new Exam()
                {
                   Title = "JavaScript exam entry level",
                   Instructions = "Some text about JavaScript exam",
                   TimeLimit = new TimeSpan(0,0,20,0,0),
                   IsActive = true,
                   CourseId = 1,
                   ExamOwnerId = 1
                });
                context.SaveChanges();

                context.Exams.Add(new Exam()
                {
                    Title = "Angular exam master",
                    Instructions = "Some text about Angular exam",
                    TimeLimit = new TimeSpan(0, 0, 15, 0, 0),
                    IsActive = true,
                    CourseId = 2,
                    ExamOwnerId = 1
                });
                context.SaveChanges();

                context.Exams.Add(new Exam()
                {
                    Title = "Product management exam",
                    Instructions = "Some text about product management exam",
                    TimeLimit = new TimeSpan(0, 0, 25, 0, 0),
                    IsActive = true,
                    CourseId = 6,
                    ExamOwnerId = 1
                });
                context.SaveChanges();
            }

            if (!context.Questions.Any(x => x.QuestionId == 1))
            {
                context.Questions.Add(new Question()
                {
                   QuestionCategoryId = 1,
                   QuestionTypeId = 2,
                   ExamId = 1,
                   Points = 20,
                   IsActive = true,
                   Text = "Inside which HTML element do we put the JavaScript?",
                   QuestionNumber = 1

                });
                context.SaveChanges();

                context.Questions.Add(new Question()
                {
                    QuestionCategoryId = 1,
                    QuestionTypeId = 2,
                    ExamId = 1,
                    Points = 15,
                    IsActive = true,
                    Text = "Where is the correct place to insert a JavaScript?",
                    QuestionNumber = 2

                });
                context.SaveChanges();

                context.Questions.Add(new Question()
                {
                    QuestionCategoryId = 1,
                    QuestionTypeId = 2,
                    ExamId = 1,
                    Points = 15,
                    IsActive = true,
                    Text = "How do you create a function in JavaScript?",
                    QuestionNumber = 3

                });
                context.SaveChanges();

                context.Questions.Add(new Question()
                {
                    QuestionCategoryId = 1,
                    QuestionTypeId = 2,
                    ExamId = 1,
                    Points = 10,
                    IsActive = true,
                    Text = "How do you call a function named 'myFunction'?",
                    QuestionNumber = 4

                });
                context.SaveChanges();

                context.Questions.Add(new Question()
                {
                    QuestionCategoryId = 1,
                    QuestionTypeId = 2,
                    ExamId = 1,
                    Points = 18,
                    IsActive = true,
                    Text = "How to write an IF statement in JavaScript?",
                    QuestionNumber = 5

                });
                context.SaveChanges();
            }

            if (!context.Choices.Any(x => x.ChoiceId == 1))
            {
                context.Choices.Add(new Choice()
                {
                   QuestionId = 1,
                   Text = "<scripting>",
                   Percentage = 0,
                   IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 1,
                    Text = "<js>",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 1,
                    Text = "<javascript>",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 1,
                    Text = "<script>",
                    Percentage = 100,
                    IsCorrect = true

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 2,
                    Text = "Both the <head> and the <ody> section are correct",
                    Percentage = 100,
                    IsCorrect = true

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 2,
                    Text = "The <head> section",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 2,
                    Text = "The <body> section",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 3,
                    Text = "function = myFunction()",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 3,
                    Text = "function: myFunction()",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 3,
                    Text = "function myFunction()",
                    Percentage = 100,
                    IsCorrect = true

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 4,
                    Text = "myFunction()",
                    Percentage = 100,
                    IsCorrect = true

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 4,
                    Text = "call myFunction()",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 4,
                    Text = "call function myFunction()",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 5,
                    Text = "if i = 5 then",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 5,
                    Text = "if i = 5",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 5,
                    Text = "if (i == 5)",
                    Percentage = 100,
                    IsCorrect = true

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    QuestionId = 5,
                    Text = "if i == 5 then",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();
            }

            if (!context.Announcements.Any(x => x.AnnouncementId == 1))
            {
                context.Announcements.Add(new Announcement()
                {
                  Title = "Announcement about course",
                  ShortDescription = "Announcement about new update for section 16",
                  Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse metus tortor, commodo vitae scelerisque eget, tempus et sapien. Morbi sed ligula a sem mattis imperdiet. Phasellus maximus, sem vel aliquam auctor, dui risus sollicitudin tortor, at semper odio nulla ac magna. Sed nec venenatis tellus, id ultricies nisl.",
                  AnnouncementOwnerId = 1,
                  FilterTypeId = 3,
                  PostOwner = "Professor Desktop"
                });
                context.SaveChanges();

                context.Announcements.Add(new Announcement()
                {
                    Title = "Announcement about course start",
                    ShortDescription = "Announcement about new update for section 19",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse metus tortor, commodo vitae scelerisque eget, tempus et sapien. Morbi sed ligula a sem mattis imperdiet.",
                    AnnouncementOwnerId = 4,
                    FilterTypeId = 1,
                    PostOwner = "Glen Hart"
                });
                context.SaveChanges();
            }

            if (!context.AnnouncementFilters.Any(x => x.AnnouncementFilterId == 1))
            {
                context.AnnouncementFilters.Add(new AnnouncementFilter()
                {
                    AnnouncementId = 1,
                    CourseTypeId = 1,
                    CourseSectionId = 1,
                    CourseId = 1
                   
                });
                context.SaveChanges();

                context.AnnouncementFilters.Add(new AnnouncementFilter()
                {
                    AnnouncementId = 2,
                    CourseTypeId = 1,
                    CourseSectionId = 4,
                    CourseId = 4

                });
                context.SaveChanges();
            }

            if (!context.Documents.Any(x => x.DocumentId == 1))
            {
                context.Documents.Add(new Document()
                {
                    FileName = "66b12160-351a-40a5-9027-25c71d27b1f8.pdf",
                    FileExstension = ".pdf",
                    ContentType = "application/pdf",
                    FileOldName = "RSII_P6_2017_18.pdf",
                    UploadDate = DateTime.Now,
                    Path= "Resources/66b12160-351a-40a5-9027-25c71d27b1f8.pdf"
                });
                context.SaveChanges();
            }

            if (!context.DocumentShares.Any(x => x.DocumentShareId == 1))
            {
                context.DocumentShares.Add(new DocumentShare()
                {
                    DocumentId = 1,
                    CourseId = 1
                });
                context.SaveChanges();
            }
        }
    }
}
