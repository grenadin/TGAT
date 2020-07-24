using System.Collections;
using System.Collections.Generic;

namespace TGAT.Model
{
    public class Course
    {
        public int CourseID { get; set; }
        public int CourseTGATID { get; set; }
        public string Title { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}