using IcmaLearn.Model.Edmx;
using IcmaLearn.Model.ViewModel;
using IcmaLearn.Repository.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace IcmaLearn.Business
{
    public class CourseBusiness
    {
        #region Fields
        private readonly ICourseService _icourseService;
        #endregion

        public CourseBusiness(ICourseService courseService)
        {
            _icourseService = courseService;
        }


        public bool CreateCourse(CourseViewModel course)
        {
            return _icourseService.CreateCourse(course);
        }

        public bool CreateCourseFile(CourseFileViewModel courseFile)
        {
            return _icourseService.CreateCourseFile(courseFile);
        }

        public List<CourseCategory> GetCourseCategories()
        {
            return _icourseService.GetCourseCategories();
        }

        public CourseFileViewModel UploaFile(IFormFile file)
        {
            return _icourseService.UploadFile(file); 
        }

        public List<CourseScoreViewModel> GetCourseUserHighiestScore()
        {
            return _icourseService.GetCourseUserHighiestScore();
        }
    }
}
