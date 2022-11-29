using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string TeacherName { get; set; }
        public int Mark  { get; set; }

        public Student(string firstname, string lastname, string username, string teacher, int mark)
        {
            
            FirstName = firstname;
            LastName = lastname;
            Username = username;
            TeacherName = teacher;
            Mark = mark;
        }
    }
}
