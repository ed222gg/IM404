using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imlabb4
{
    class TestReferee
    {
        public TestReferee()
        {
            if (this.TestSetUsername())
            {
                Console.WriteLine("Test-ID:1 SetUsername:\t\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:1 SetUsername:\t\t\tfail");
            }

            if (this.TestSetWrongUsername())
            {
                Console.WriteLine("Test-ID:2 SetWrongUsername:\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:2 SetWrongUsername:\t\tfail");
            }

            if (this.TestSetPassword())
            {
                Console.WriteLine("Test-ID:3 SetPassword:\t\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:3 SetPassword:\t\t\tfail");
            }

            if (this.TestSetWrongPassword())
            {
                Console.WriteLine("Test-ID:4 SetWrongPassword:\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:4 SetWrongPassword:\t\tfail");
            }

            if (this.TestSetScore())
            {
                Console.WriteLine("Test-ID:5 SetScore:\t\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:5 SetScore:\t\t\tfail");
            }

            if (this.TestSetWrongScore())
            {
                Console.WriteLine("Test-ID:6 SetWrongScore:\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:6 SetWrongScore:\t\tfail");
            }
            if (this.TestSetAllScored())
            {
                Console.WriteLine("Test-ID:7 SetAllScored:\t\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:7 SetAllScored:\t\t\tfail");
            }

            if (this.TestSetWrongAllScored())
            {
                Console.WriteLine("Test-ID:8 SetWrongScore:\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:8 SetWrongScore:\t\tfail");
            }
        }

        //1

        public bool TestSetUsername()
        {
            Referee judge = new Referee();

            try
            {
                judge.Username = "domarcalle";
                return true;
                
            }
            catch (Exception e)
            {
                return false;
            }
           

        }

        //2
        public bool TestSetWrongUsername()
        {
            Referee judge = new Referee();
            try
            {
                judge.Username = "";

                return false;
                
            }
            catch (Exception e)
            {
                return true;
            }
        }

        //3
        public bool TestSetPassword()
        {
            Referee judge = new Referee();

            try
            {
                judge.Password = 1111;

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        //4
        public bool TestSetWrongPassword()
        {
            Referee judge = new Referee();

            try
            {
                judge.Password = 111;

                return false;

            }
            catch (Exception e)
            {
                return true;
            }
        }

        //5
        public bool TestSetScore()
        {
            Referee judge = new Referee();
            Gymnast g = new Gymnast();
            try
            {
                judge.SetScore(5, g);
                return true;
            }
            catch (Exception e)
            {
               return false;
            }
        }

        //6
           public bool TestSetWrongScore()
        {
            Referee judge = new Referee();
            Gymnast g = new Gymnast();
            try
            {
                judge.SetScore(-5, g);
                return false;
            }
            catch (Exception e)
            {
                return true;
            }
        }
          
        //7
           public bool TestSetAllScored()
           {
               Referee judge = new Referee();

               try
               {
                   judge.AllScored = 12345678;

                   return true;

               }
               catch (Exception e)
               {
                   return false;
               }
           }
       
        //8
           public bool TestSetWrongAllScored()
           {
               Referee judge = new Referee();

               try
               {
                   judge.AllScored = 1234567;

                   return false;

               }
               catch (Exception e)
               {
                   return true;
               }
           }
    }
}
