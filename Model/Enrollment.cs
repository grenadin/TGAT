using System;
    
namespace TGAT.Model
{
    public enum Grade
    {
        A,B,C,D,E,F //A :80,B :70, C :60, D :50, E:<40
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? grade { get; set; }

        public DateTime Login { get; set; }
        public DateTime LogOut { get; set; }

        



        public Course Course { get; set; }
        public Student Student { get; set; }

    }
}