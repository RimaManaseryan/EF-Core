using EF_Core.Entities;
using System;


namespace EF_Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region N2 User

            // List<User> users = new List<User>();
            using (EFCoreContext db = new EFCoreContext())
            {
                int key = 99;
                while (key != 0)
                {
                    Console.WriteLine($"\n0 Exit\n1 Login\n2 Registration");
                    key = int.Parse(Console.ReadLine());
                    if (key == 2)
                    {
                        Console.WriteLine("Type your name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Type your surname:");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Password");
                        string password = Console.ReadLine();
                        User user = new User(name, surname, username, password);
                        db.Users.Add(user);
                        db.SaveChanges();

                    }
                    else if (key == 1)
                    {
                        Console.WriteLine("Surname:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Password");
                        string password = Console.ReadLine();


                        bool checker = false;
                        foreach (User user in db.Users)
                        {
                            if (user == null) break;
                            if (username == user.Login && password == user.Password)
                            {
                                checker = true;
                                Console.WriteLine($"Hello, {user.Name}");
                            }
                        }
                        if (!checker)
                        {
                            Console.WriteLine("Wrong username or password");
                        }
                        else
                        {
                            Console.WriteLine("3 - Logout");
                            key = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }

            #endregion
        }
    }
}
