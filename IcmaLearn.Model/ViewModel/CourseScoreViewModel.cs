using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcmaLearn.Model.ViewModel
{
    public class CourseScoreViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseCategoryName { get; set; }
        public virtual UserScoreViewModel CourseHighiestScore { get; set; }
    }
}
