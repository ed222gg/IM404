using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imlabb4
{
    class TestRegisterContest
    {

        public TestRegisterContest()
        {
            if (this.TestAdminUsername())
            {
                Console.WriteLine("Test-ID:9 SetAdminUserName:\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:9 SetAdminUserName:\t\tfail");
            }

            if (this.TestWrongAdminUsername())
            {
                Console.WriteLine("Test-ID:10 SetWrongAdminUserName:\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:10 SetWrongAdminUserName:\tfail");
            }

            if (this.TestAdminPassword())
            {
                Console.WriteLine("Test-ID:11 SetAdminPassword:\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:11 SetAdminPassword:\t\tfail");
            }


            if (this.TestChooseEventDate())
            {
                Console.WriteLine("Test-ID:12 SetChooseEventDate:\t\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:12 SetChooseEventDate:\t\tfail");
            }


            if (this.TestWrongChooseEventDate())
            {
                Console.WriteLine("Test-ID:13 SetWrongChooseEventDate:\tpass");
            }
            else
            {
                Console.WriteLine("Test-ID:13 SetWrongChooseEventDate:\tfail");
            }
        }

        //9
        public bool TestAdminUsername()
        {
            RegisterContest admin = new RegisterContest();

            try
            {
                admin.Username = "adminbjörn";
                if (admin.Username != "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch (Exception e)
            {
                return false;
            }
        }


        //10
        public bool TestWrongAdminUsername()
        {
            RegisterContest admin = new RegisterContest();
            try
            {
                admin.Username = "hgf";

                return true; ;

            }
            catch (Exception e)
            {
                return false;
            }
        }


        //11
        public bool TestAdminPassword()
        {
            RegisterContest admin = new RegisterContest();

            try
            {
                admin.Password = 1111;
                if (admin.Password != 111)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }       


        //12

        public bool TestChooseEventDate()
        {
            RegisterContest admin = new RegisterContest();
            DateTime date = new DateTime(2014 - 12 - 12);
            try
            {
                admin.ChooseEventDate = new DateTime(2014 - 12 - 1);  //kolla datum
                if (admin.ChooseEventDate != date)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }


        //13
        public bool TestWrongChooseEventDate()
        {
            RegisterContest admin = new RegisterContest();
            DateTime date = new DateTime(2014 - 12 - 12);
            try
            {
                admin.ChooseEventDate = new DateTime();  //kolla datum
                if (admin.ChooseEventDate != date)
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
                return true;
            }
        }
    }
}
