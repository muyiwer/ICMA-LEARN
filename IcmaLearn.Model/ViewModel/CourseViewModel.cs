using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcmaLearn.Model.ViewModel
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    }
}
