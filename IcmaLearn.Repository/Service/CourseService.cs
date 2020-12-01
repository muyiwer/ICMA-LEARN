using IcmaLearn.Model.Edmx;
using IcmaLearn.Model.ViewModel;
using IcmaLearn.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace IcmaLearn.Repository.Service
{
    public class CourseService : BaseService,ICourseService
    {
        public bool CreateCourse(CourseViewModel clientCourse) 
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    Course course = new Course
                    {
                        CategoryId = clientCourse.CategoryId,
                        Description = clientCourse.Description,
                        Name = clientCourse.Name,
                        Title = clientCourse.Title
                    };
                    db.Courses.Add(course);
                    db.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch 
                {
                    throw;
                }
               
            }
        }

        public bool CreateCourseFile(CourseFileViewModel clientCourseFile) 
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    CourseFile courseFiles = new CourseFile
                    {
                        CourseId = clientCourseFile.CourseId,
                        Name = clientCourseFile.Name,
                        Path = clientCourseFile.Path
                    };
                    db.CourseFiles.Add(courseFiles);
                    db.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    throw;
                }

            }
        }

        public CourseFileViewModel UploadFile(IFormFile file)
        {
            try
            {
                string _FileName = Path.GetFileName(file.FileName);
                string _path = ""; Path.Combine(@"C:\Pictures\", _FileName);
                using (var stream = new FileStream(_path, FileMode.CreateNew))
                {
                    file.CopyToAsync(stream);
                }
                return new CourseFileViewModel
                {
                    Path = _path,
                    Name = file.FileName
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public List<CourseScoreViewModel> GetCourseUserHighiestScore()
        {
            try
            {
                var result = db.Courses.Select(x => new
                {
                    x.Id,
                    x.Name,
                    CourseCategoryName = x.Category.Name,
                    CourseHighiestScore = x.UserScores.Select(y=> new
                    {
                        y.Id,
                        FullName = y.User.FirstName + " " + y.User.LastName,
                        y.Score
                    }).OrderByDescending(y=> y.Score).FirstOrDefault()
                });
                if (result.Any())
                {
                    var courseScore = JsonConvert.SerializeObject(result);
                   return JsonConvert.DeserializeObject<List<CourseScoreViewModel>>(courseScore);
                }
                else
                {
                    return new List<CourseScoreViewModel>();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CourseCategory> GetCourseCategories()
        {
            return db.CourseCategories.ToList();
        }

        private bool disposedValue = false; 
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposedValue = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
