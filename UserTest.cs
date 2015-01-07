using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imlabb4
{
    class UnitTestUser
    {

        public UnitTestUser()
        {
            if (this.TestUserUserName())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(String.Format("Test UserName: {0}", this.TestUserUserName().ToString()));
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(String.Format("Test UserName: {0}", this.TestUserUserName().ToString()));
            }

            if (this.TestUserPassword())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(String.Format("Test Password: {0}", this.TestUserPassword().ToString()));
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(String.Format("Test Password: {0}", this.TestUserPassword().ToString()));
            }
            if (this.TestUserPassword())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(String.Format("Test Password: {0}", this.TestUserPassword().ToString()));
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(String.Format("Test Password: {0}", this.TestUserPassword().ToString()));
            }
        }

        private bool TestUserPassword()
        {
            User u = new User();

            u.Password = 1234;

            if (u.Password != 1234)
            {
                return false;
            }

            else
            {
                return true;
            }

        }

        private bool TestUserUserName()
        {
            User u = new User();

            u.UserName = "Bamse";

            if (u.UserName != "Bamse")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private bool TestUserLogIn()
        {
            User u = new User();
            u.UserName = "Calle";
            u.Password = 3333;

            try
            {
                if (u.LogIn())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}