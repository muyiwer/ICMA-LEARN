using System;
using System.Collections.Generic;

#nullable disable

namespace IcmaLearn.Model.Edmx
{
    public partial class User
    {
        public User()
        {
            UserCourses = new HashSet<UserCourse>();
            UserScores = new HashSet<UserScore>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual ICollection<UserCourse> UserCourses { get; set; }
        public virtual ICollection<UserScore> UserScores { get; set; }
    }
}
