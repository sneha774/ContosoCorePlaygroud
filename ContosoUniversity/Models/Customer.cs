using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ContosoUniversity.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}