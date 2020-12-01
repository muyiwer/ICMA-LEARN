using System;
using System.Collections.Generic;

#nullable disable

namespace IcmaLearn.Model.Edmx
{
    public partial class CourseFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CourseId { get; set; }
        public string DateCreated { get; set; }
        public string Path { get; set; }

        public virtual Course Course { get; set; }
    }
}
