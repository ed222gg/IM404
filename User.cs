using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imlabb4
{
    class User
    {
        private string _username;

        public string UserName
        {
            get { return this._username; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("No _username");
                }
                _username = value; 
            }
        }


        public int Password 
        { get; set; }

        //    get { return this._password; }
        //    set  { _pasword = value; }

        public bool LogIn()
        {
            Dictionary<String, int> users = new Dictionary<string, int>();
            users.Add("adam", 1111);
            users.Add("sanna", 2222);           
            users.Add("dan", 3333);

            
            if (this.Password == null)
            {
                throw new Exception("No _password");
            }

            int password;
            
            users.TryGetValue(this._username.ToLower(), out password);
            
            if (password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}