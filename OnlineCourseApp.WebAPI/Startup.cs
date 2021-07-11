using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Services;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OnlineCourseApp.WebAPI.Filters;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.Model.Requests.Videos;
using Microsoft.AspNetCore.Authentication;
using OnlineCourseApp.WebAPI.Security;
using OnlineCourseApp.Model.Requests.Exams;
using OnlineCourseApp.Model.Requests.Questions;
using OnlineCourseApp.Model.Requests.Choices;
using OnlineCourseApp.Model.Requests.Announcements;
using OnlineCourseApp.Model.Requests.CourseParticipants;

namespace OnlineCourseApp.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddAutoMapper(typeof(Startup));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme() {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
                //c.CustomSchemaIds(type => type.ToString());

            });

            var connection = @"Server=.; Database=160065; Trusted_Connection=True;";
            services.AddDbContext<_160065Context>(options => options.UseSqlServer(connection));

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IBaseCRUDService<Model.Courses,CoursesSearchRequest,CoursesInsertRequest,CoursesInsertRequest>, CourseService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IBaseService<CourseTypes, object>, BaseService<CourseTypes,object, CourseType>>();
            services.AddScoped<IBaseService<CourseSections, object>, BaseService<CourseSections, object, CourseSection>>();
            services.AddScoped<IBaseService<QuestionCategories, object>, BaseService<QuestionCategories, object, QuestionCategory>>();
            services.AddScoped<IBaseService<QuestionTypes, object>, BaseService<QuestionTypes, object, QuestionType>>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IBaseCRUDService<Model.Documents, DocumentsSearchRequest, DocumentsInsertRequest, DocumentsInsertRequest>, DocumentService>();
            services.AddScoped<IVideoService, VideoService>();
            services.AddScoped<IBaseCRUDService<Model.Videos, VideosSearchRequest, VideosInsertRequest, VideosInsertRequest>, VideoService>();
            services.AddScoped<IBaseCRUDService<Model.Exams, ExamsSearchRequest, ExamsInsertRequest, ExamsInsertRequest>, ExamService>();
            services.AddScoped<IBaseCRUDService<Model.Questions, QuestionsSearchRequest, QuestionsInsertRequest, QuestionsInsertRequest>, QuestionService>();
            services.AddScoped<IBaseCRUDService<Model.Choices, ChoicesSearchRequest, ChoicesInsertRequest, ChoicesInsertRequest>, ChoiceService>();
            services.AddScoped<IBaseCRUDService<Model.Announcements, AnnouncementsSearchRequest, AnnouncementsInsertRequest, AnnouncementsInsertRequest>, AnnouncementService>();
            services.AddScoped<IBaseService<Model.AnnouncementFilterTypes, object>, BaseService<Model.AnnouncementFilterTypes, object, AnnouncementFilterType>>();
            services.AddScoped<IBaseCRUDService<Model.AnnouncementFilters, AnnouncementFiltersSearchRequest, AnnouncementFiltersInsertRequest, AnnouncementFiltersInsertRequest>, AnnouncementFiltersService>();
            services.AddScoped<IBaseCRUDService<Model.CourseParticipants, CourseParticipantsSearchRequest, CourseParticipantsInsertRequest, CourseParticipantsInsertRequest>, CourseParticipantService>();
            services.AddScoped<IDocumentDownloadedService, DocumentDownloadedService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAPI V1");
            });


            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
