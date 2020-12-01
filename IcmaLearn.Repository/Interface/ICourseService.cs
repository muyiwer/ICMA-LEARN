using IcmaLearn.Model.Edmx;
using IcmaLearn.Model.ViewModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace IcmaLearn.Repository.Interface
{
    public interface ICourseService
    {
        bool CreateCourse(CourseViewModel course);
        bool CreateCourseFile(CourseFileViewModel courseFile);
        CourseFileViewModel  UploadFile(IFormFile file);
        List<CourseScoreViewModel> GetCourseUserHighiestScore();
        List<CourseCategory> GetCourseCategories(); 
    }
}
