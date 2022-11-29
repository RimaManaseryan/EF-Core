using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public decimal Salary { get; set; }

        public Teacher(string firstname, string lastname, string subject, int salary)
        {
            FirstName = firstname;
            LastName = lastname;
            Subject = subject;
            Salary = salary;
        }
    }
}
