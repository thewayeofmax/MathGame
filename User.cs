using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class User
    {
        private string userName;
        DateTime date = DateTime.UtcNow;

        Utils Utilities = new Utils();

        public void userLogin()
        {
            Console.WriteLine("Please state your name: ");
            string username = Console.ReadLine();

            if (username == "")
            {
                Console.WriteLine("Wrong input");
                userLogin();
            }
            else
            {
                userName = username;
                loginMessage();
            }
        }

        public void loginMessage()
        {
            Console.WriteLine($"\nWelcome {userName} to the Math Game! The date of your login is: {date}.\n");
        }
    }
}
