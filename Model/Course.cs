using System.Collections;
using System.Collections.Generic;

namespace TGAT.Model
{
    public class Course//ppl /ir /me /cfi /cpl
    {
        public int CourseID { get; set; }
        public int CourseTGATID { get; set; }
        public string Title { get; set; }
        public int Hour { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }

    //ppl total hour  
}