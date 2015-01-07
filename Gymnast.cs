using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imlabb4
{
    class Gymnast
    {
        private int _score;
        

        public int Score 
        { 
            get 
            {
                return _score;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _score = value;
                }
            }         
        }
        private String _personalID;
        public String PersonalID
        {
            get
            {
                return _personalID;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _personalID = value;
                }
            }
        }

        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private String _team;
        public String Team
        {
            get { return _team; }
            set { _team = value; }
        }

    }
}
