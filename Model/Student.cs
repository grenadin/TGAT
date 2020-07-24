using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TGAT.Model
{
    public class Student
    {
        public int ID { get; set; }
       
        public int StudentTGATId { get; set; }
        public string Rank { get; set; } 


        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string FullName { get => FirstName +" "+ LastName; }

        [Required]
        public string FirstNameThai { get; set; }

        [Required]
        public string LastNameThai { get; set; }
        public string FullNameThai { get => FirstNameThai + " " + LastNameThai; }


        public string Address { get; set; }
        public string Mobile { get; set; }

        [Required]
        public string Email { get; set; }
        public string License { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        public int MyProperty { get; set; }


    }
}
