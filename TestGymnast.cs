using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imlabb4
{
    class TestGymnast
    {
        public TestGymnast()
        {
            if (this.TestPersonalID())
            {
                Console.WriteLine("Test TestPersonalID: pass");
            }
            else
            {
                Console.WriteLine("Test TestPersonalID: fail");
            }

            if (this.TestGymnastName())
            {
                Console.WriteLine("Test TestGymnastName: pass");
            }
            else
            {
                Console.WriteLine("Test TestGymnastName: fail");
            }

            if (this.TestTeam())
            {
                Console.WriteLine("Test TestTeam: pass");
            }
            else
            {
                Console.WriteLine("Test TestTeam: fail");
            }
        }

        public bool TestPersonalID()
        {
            Gymnast gymnast = new Gymnast();

            try
            {
                gymnast.PersonalID = "1111";
                if (gymnast.PersonalID != "1111")
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

        public bool TestGymnastName()
        {
            Gymnast gymnast = new Gymnast();

            try
            {
                gymnast.Name = "Carro";
                if (gymnast.Name != "Carro")
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

        public bool TestTeam()
        {
            Gymnast gymnast = new Gymnast();

            try
            {
                gymnast.Name = "Lag 1";
                if (gymnast.Name != "Lag 1")
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
    }

}
