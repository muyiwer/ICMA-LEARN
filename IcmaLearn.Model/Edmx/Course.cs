using System;
using System.Collections.Generic;

#nullable disable

namespace IcmaLearn.Model.Edmx
{
    public partial class Course
    {
        public Course()
        {
            CourseFiles = new HashSet<CourseFile>();
            UserCourses = new HashSet<UserCourse>();
            UserScores = new HashSet<UserScore>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Title { get; set; }

        public virtual CourseCategory Category { get; set; }
        public virtual ICollection<CourseFile> CourseFiles { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
        public virtual ICollection<UserScore> UserScores { get; set; }
    }
}
