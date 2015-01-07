using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imlabb4
{
    class RegisterContest
    {
        public RegisterContest()
        {

        }

        //1
        private String _username;

        public String Username
        {
            get { return _username; }
            set { _username = value; }
        }

        //2
        private int _password;
        public int Password
        {
            get { return _password; }
            set { _password = value; }
        }


        //3
        private DateTime _chooseEventDate;
        public DateTime ChooseEventDate
        {
            get { return _chooseEventDate; } 
            set { _chooseEventDate = value; }
        }
    }

}

