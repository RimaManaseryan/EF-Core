using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class User
    {
        public string Username
        {
            get { return Username; }
            set
            {
                if(value.Contains('@') && value.Contains('.'))
                {
                    Username = value;
                }
                else Console.WriteLine("Your username must be a valid email address.");
            }
        }
        public string Password
        {
            get { return Password; }
            set
            {

                if (value.Length >= 8 && 
                    value.Where(s => s.IsIn('0', '1', '2', '3', '4', '5', '6', '7', '8', '9')).Count()>2 &&
                    value.Where(s=>s.IsIn('/', '&', '.')).Any())
                {
                    Password = value;
                }
                else Console.WriteLine("Your password must contain at least 8 characters, 2 numbers and \"/\", \"&\", \".\" symbols");
            }
        }
        public int Id { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
