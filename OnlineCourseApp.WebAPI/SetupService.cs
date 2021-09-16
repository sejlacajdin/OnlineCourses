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
                context.Roles.Add(new Role() { RoleId=1, Name = "Professor", Description = "" });
                context.SaveChanges();
                context.Roles.Add(new Role() {RoleId=2, Name = "Student", Description = "" });
                context.SaveChanges();

            }

            if (!context.Users.Any(x => x.Username == "desktop"))
            {
                context.Users.Add(new User() { 
                    UserId = 1,
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
                    UserId = 2,
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
                    UserId = 3,
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
                    UserId = 4,
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
                    UserId = 5,
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
                    UserId = 6,
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
                    UserId = 7,
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
                    UserId = 8,
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
                  UserRolesId = 1,
                  UserId = 1,
                  RoleId = 1,
                  RecordUpdated = new DateTime()

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserRolesId = 2,
                    UserId = 2,
                    RoleId = 2,
                    RecordUpdated = new DateTime()

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserRolesId = 3,
                    UserId = 3,
                    RoleId = 1,
                    RecordUpdated = new DateTime()

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserRolesId = 4,
                    UserId = 4,
                    RoleId = 1,
                    RecordUpdated = new DateTime()

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserRolesId = 5,
                    UserId = 5,
                    RoleId = 1,
                    RecordUpdated = new DateTime()

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserRolesId = 6,
                    UserId = 6,
                    RoleId = 2,
                    RecordUpdated = new DateTime()

                });
                context.SaveChanges();
                context.UserRoles.Add(new UserRole()
                {
                    UserRolesId = 7,
                    UserId = 7,
                    RoleId = 2,
                    RecordUpdated = new DateTime()

                });
                context.SaveChanges();

                context.UserRoles.Add(new UserRole()
                {
                    UserRolesId = 8,
                    UserId = 8,
                    RoleId = 2,
                    RecordUpdated = new DateTime()

                });
                context.SaveChanges();
            }

            if (!context.QuestionTypes.Any(x => x.TypeName == "MCMA"))
            {
                context.QuestionTypes.Add(new QuestionType()
                {
                    QuestionTypeId = 1,
                    TypeName = "MCMA"

                });
                context.SaveChanges();

                context.QuestionTypes.Add(new QuestionType()
                {
                    QuestionTypeId = 2,
                    TypeName = "MCSA"

                });
                context.SaveChanges();
            }

            if (!context.QuestionCategories.Any(x => x.CategoryName == "Basic"))
            {
                context.QuestionCategories.Add(new QuestionCategory()
                {
                   QuestionCategoryId = 1,
                   CategoryName = "Basic"
                });
                context.SaveChanges();

                context.QuestionCategories.Add(new QuestionCategory()
                {
                    QuestionCategoryId = 2,
                    CategoryName = "Medium"
                });
                context.SaveChanges();

                context.QuestionCategories.Add(new QuestionCategory()
                {
                    QuestionCategoryId = 3,
                    CategoryName = "Hard"
                });
                context.SaveChanges();
            }

            if (!context.CourseTypes.Any(x => x.CourseTypeId == 1))
            {
                context.CourseTypes.Add(new CourseType()
                {
                     CourseTypeId = 1, 
                     Name = "Development",
                     RecordUpdated = new DateTime()
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    CourseTypeId = 2,
                    Name = "Business",
                    RecordUpdated = new DateTime()
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    CourseTypeId = 3,
                    Name = "Finance & Accounting",
                    RecordUpdated = new DateTime()
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    CourseTypeId = 4,
                    Name = "IT & Software",
                    RecordUpdated = new DateTime()
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    CourseTypeId = 5,
                    Name = "Design",
                    RecordUpdated = new DateTime()
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    CourseTypeId = 6,
                    Name = "Marketing",
                    RecordUpdated = new DateTime()
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    CourseTypeId = 7,
                    Name = "Music",
                    RecordUpdated = new DateTime()
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    CourseTypeId = 8,
                    Name = "Lifestyle",
                    RecordUpdated = new DateTime()
                });
                context.SaveChanges();

                context.CourseTypes.Add(new CourseType()
                {
                    CourseTypeId = 9,
                    Name = "Photography & Video",
                    RecordUpdated = new DateTime()
                });
                context.SaveChanges();
            }

            if (!context.CourseSections.Any(x => x.CourseSectionId == 1))
            {
                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 1,
                    Name = "Web Development",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 2,
                    Name = "Data Science",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 3,
                    Name = "Mobile Development",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 4,
                    Name = "Game Development",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 5,
                    Name = "JavaScript",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = 1
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 6,
                    Name = "React",
                    Description = "",
                    CourseTypeId = 1,
                    CourseParentId = 1
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 7,
                    Name = "Entrepreneurship",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 8,
                    Name = "Communication",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 9,
                    Name = "Management",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 10,
                    Name = "Sales",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 11,
                    Name = "Media",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 12,
                    Name = "Business Law",
                    Description = "",
                    CourseTypeId = 2,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 13,
                    Name = "Compliance",
                    Description = "",
                    CourseTypeId = 3,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 14,
                    Name = "Economics",
                    Description = "",
                    CourseTypeId = 3,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 15,
                    Name = "Finance",
                    Description = "",
                    CourseTypeId = 3,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 16,
                    Name = "Taxes",
                    Description = "",
                    CourseTypeId = 3,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 17,
                    Name = "Network & Security",
                    Description = "",
                    CourseTypeId = 4,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 18,
                    Name = "Hardware",
                    Description = "",
                    CourseTypeId = 4,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 19,
                    Name = "Web Design",
                    Description = "",
                    CourseTypeId = 5,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 20,
                    Name = "Design Tools",
                    Description = "",
                    CourseTypeId = 5,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 21,
                    Name = "Game Design",
                    Description = "",
                    CourseTypeId = 5,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 22,
                    Name = "Digital Marketing",
                    Description = "",
                    CourseTypeId = 6,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 23,
                    Name = "Branding",
                    Description = "",
                    CourseTypeId = 6,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 24,
                    Name = "Public Relations",
                    Description = "",
                    CourseTypeId = 6,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 25,
                    Name = "Instruments",
                    Description = "",
                    CourseTypeId = 7,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 26,
                    Name = "Music Techniques",
                    Description = "",
                    CourseTypeId = 7,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 27,
                    Name = "Arts & Crafts",
                    Description = "",
                    CourseTypeId = 8,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 28,
                    Name = "Food & Beverage",
                    Description = "",
                    CourseTypeId = 8,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 29,
                    Name = "Digital Photography",
                    Description = "",
                    CourseTypeId = 9,
                    CourseParentId = null
                });
                context.SaveChanges();

                context.CourseSections.Add(new CourseSection()
                {
                    CourseSectionId = 30,
                    Name = "Video Design",
                    Description = "",
                    CourseTypeId = 9,
                    CourseParentId = null
                });
                context.SaveChanges();
            }

            if (!context.AnnouncementFilterTypes.Any(x => x.AnnouncementFilterTypeId == 1))
            {
                context.AnnouncementFilterTypes.Add(new AnnouncementFilterType()
                {
                   AnnouncementFilterTypeId = 1,
                   Name = "All users"
                });
                context.SaveChanges();

                context.AnnouncementFilterTypes.Add(new AnnouncementFilterType()
                {
                    AnnouncementFilterTypeId = 2,
                    Name = "Professors"
                });
                context.SaveChanges();

                context.AnnouncementFilterTypes.Add(new AnnouncementFilterType()
                {
                    AnnouncementFilterTypeId = 3,
                    Name = "Students"
                });
                context.SaveChanges();
            }

            if (!context.Courses.Any(x => x.CourseId == 1))
            {
                context.Courses.Add(new Course()
                {
                   CourseId = 1,
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
                    CourseId = 2,
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
                    CourseId = 3,
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
                    CourseId = 4,
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
                    CourseId = 5,
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
                    CourseId = 6,
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
                    CourseId = 7,
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
                    CourseId = 8,
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
                    CourseId = 9,
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
                    CourseParticipantId = 1,
                    StudentId = 2,
                    CourseId = 1,
                    Comment = "",
                    Review = 3,
                    ParticipationDate = new DateTime()
                }); 
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 2,
                    StudentId = 2,
                    CourseId = 2,
                    Comment = "",
                    Review = 4,
                    ParticipationDate = new DateTime()
                }); 
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 3,
                    StudentId = 2,
                    CourseId = 3,
                    Comment = "",
                    Review = 5,
                    ParticipationDate = new DateTime()
                }); 
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 4,
                    StudentId = 2,
                    CourseId = 5,
                    Comment = "",
                    Review = 5,
                    ParticipationDate = new DateTime()
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 5,
                    StudentId = 6,
                    CourseId = 3,
                    Comment = "",
                    Review = 5,
                    ParticipationDate = new DateTime()
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 6,
                    StudentId = 6,
                    CourseId = 1,
                    Comment = "",
                    Review = 2,
                    ParticipationDate = new DateTime()
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 7,
                    StudentId = 6,
                    CourseId = 2,
                    Comment = "",
                    Review = 3,
                    ParticipationDate = new DateTime()
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 8,
                    StudentId = 7,
                    CourseId = 1,
                    Comment = "",
                    Review = 2,
                    ParticipationDate = new DateTime()
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 9,
                    StudentId = 7,
                    CourseId = 2,
                    Comment = "",
                    Review = 3,
                    ParticipationDate = new DateTime()
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 10,
                    StudentId = 7,
                    CourseId = 6,
                    Comment = "",
                    Review = 3,
                    ParticipationDate = new DateTime()
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 11,
                    StudentId = 8,
                    CourseId = 6,
                    Comment = "",
                    Review = 4,
                    ParticipationDate = new DateTime()
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 12,
                    StudentId = 8,
                    CourseId = 1,
                    Comment = "",
                    Review = 4,
                    ParticipationDate = new DateTime()
                });
                context.SaveChanges();

                context.CourseParticipants.Add(new CourseParticipant()
                {
                    CourseParticipantId = 13,
                    StudentId = 8,
                    CourseId = 3,
                    Comment = "",
                    Review = 4,
                    ParticipationDate = new DateTime()
                });
                context.SaveChanges();
            }

            if (!context.Exams.Any(x => x.ExamId == 1))
            {
                context.Exams.Add(new Exam()
                {
                   ExamId = 1,
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
                    ExamId = 2,
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
                    ExamId = 3,
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
                   QuestionId = 1,
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
                    QuestionId = 2,
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
                    QuestionId = 3,
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
                    QuestionId = 4,
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
                    QuestionId = 5,
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
                   ChoiceId = 1,
                   QuestionId = 1,
                   Text = "<scripting>",
                   Percentage = 0,
                   IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 2,
                    QuestionId = 1,
                    Text = "<js>",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 3,
                    QuestionId = 1,
                    Text = "<javascript>",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 4,
                    QuestionId = 1,
                    Text = "<script>",
                    Percentage = 100,
                    IsCorrect = true

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 5,
                    QuestionId = 2,
                    Text = "Both the <head> and the <ody> section are correct",
                    Percentage = 100,
                    IsCorrect = true

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 6,
                    QuestionId = 2,
                    Text = "The <head> section",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 7,
                    QuestionId = 2,
                    Text = "The <body> section",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 8,
                    QuestionId = 3,
                    Text = "function = myFunction()",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 9,
                    QuestionId = 3,
                    Text = "function: myFunction()",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 10,
                    QuestionId = 3,
                    Text = "function myFunction()",
                    Percentage = 100,
                    IsCorrect = true

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 11,
                    QuestionId = 4,
                    Text = "myFunction()",
                    Percentage = 100,
                    IsCorrect = true

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 12,
                    QuestionId = 4,
                    Text = "call myFunction()",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 13,
                    QuestionId = 4,
                    Text = "call function myFunction()",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 14,
                    QuestionId = 5,
                    Text = "if i = 5 then",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 15,
                    QuestionId = 5,
                    Text = "if i = 5",
                    Percentage = 0,
                    IsCorrect = false

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 16,
                    QuestionId = 5,
                    Text = "if (i == 5)",
                    Percentage = 100,
                    IsCorrect = true

                });
                context.SaveChanges();

                context.Choices.Add(new Choice()
                {
                    ChoiceId = 17,
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
                  AnnouncementId = 1,
                  Title = "Announcement about course",
                  ShortDescription = "Announcement about new update for section 16",
                  Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse metus tortor, commodo vitae scelerisque eget, tempus et sapien. Morbi sed ligula a sem mattis imperdiet. Phasellus maximus, sem vel aliquam auctor, dui risus sollicitudin tortor, at semper odio nulla ac magna. Sed nec venenatis tellus, id ultricies nisl.",
                  AnnouncementOwnerId = 1,
                  FilterTypeId = 3,
                  PostOwner = "Professor Desktop"
                });
                context.SaveChanges();
            }

            if (!context.AnnouncementFilters.Any(x => x.AnnouncementFilterId == 1))
            {
                context.AnnouncementFilters.Add(new AnnouncementFilter()
                {
                    AnnouncementFilterId = 1,
                    AnnouncementId = 1,
                    CourseTypeId = 1,
                    CourseSectionId = 1,
                    CourseId = 1
                   
                });
                context.SaveChanges();
            }

            if (!context.Documents.Any(x => x.DocumentId == 1))
            {
                context.Documents.Add(new Document()
                {
                    DocumentId = 1,
                    FileName = "66b12160-351a-40a5-9027-25c71d27b1f8.pdf",
                    FileExstension = ".pdf",
                    ContentType = "application/pdf",
                    FileOldName = "RSII_P6_2017_18.pdf",
                    UploadDate = new DateTime(),
                    Path= "Resources/66b12160-351a-40a5-9027-25c71d27b1f8.pdf"
                });
                context.SaveChanges();
            }

            if (!context.DocumentShares.Any(x => x.DocumentShareId == 1))
            {
                context.DocumentShares.Add(new DocumentShare()
                {
                    DocumentShareId = 1,
                    DocumentId = 1,
                    CourseId = 1
                });
                context.SaveChanges();
            }
        }
    }
}
