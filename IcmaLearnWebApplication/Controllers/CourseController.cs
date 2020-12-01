using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IcmaLearn.Business;
using IcmaLearn.Model.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IcmaLearnApp.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CourseBusiness _courseBusiness;

        public CourseController(CourseBusiness courseBusiness)
        {
            _courseBusiness = courseBusiness;
        }

        [HttpGet]
        [Route("api/Course/CourseCategories")]
        public IActionResult CourseCategories()
        {
            try 
            {
                var result = _courseBusiness.GetCourseCategories();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(new
                {
                    success = false,
                    message = ex
                });
            }
        }


        [HttpPost]
        [Route("api/Course/Create")]
        public IActionResult Create([FromBody]CourseViewModel courseViewModel)
        {
            try
            {
                 _courseBusiness.CreateCourse(courseViewModel);
                return Ok(new
                {
                    success = true,
                    message = "Created successfully"
                });
            }
            catch (Exception ex)
            {
                return Ok(new
                {
                    success = false,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        [Route("api/Course/GetScore")]
        public IActionResult GetScore()
        {
            try
            {
               var result =  _courseBusiness.GetCourseUserHighiestScore();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(new
                {
                    success = false,
                    message = ex.Message
                });
            }
        }

        [HttpPost]
        [Route("api/Course/UploadFile")]
        public IActionResult UploadFile([FromForm] IFormFile file)
        {
            try
            {
                var Id = Request.Headers["CourseId"];
                var result = _courseBusiness.UploaFile(file);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(new
                {
                    success = false,
                    message = ex.Message
                });
            }
        }
    }
}