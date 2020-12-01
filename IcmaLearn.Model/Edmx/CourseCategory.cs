using System;
using System.Collections.Generic;

#nullable disable

namespace IcmaLearn.Model.Edmx
{
    public partial class CourseCategory
    {
        public CourseCategory()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
