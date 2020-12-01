using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcmaLearn.Model.ViewModel
{
    public class CourseFileViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> CourseId { get; set; }
        public string DateCreated { get; set; }
        public string Path { get; set; }
    }
}
