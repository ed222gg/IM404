using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imlabb4
{
    class Referee
    {
        public Referee()
        {

        }
        
        private string _username;

        public string Username
        {
            get { return _username; }
            set
            { 
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Strängen får ej vara tom");
                }
                _username = value; 
            }
        }

        
        private int _password;

        public int Password
        {
            get { return _password; }
            set 
            {
                if(IntLength(value) >= 4 && IntLength(value) <= 8)
                {
                    _password = value;
                }
                else 
                { 
                throw new ArgumentOutOfRangeException("Lösenordet är inte mellan 4 och 8 tecken långt ");
                }
            }
        }

        public void SetScore(int score, Gymnast gymnast) // den tilldelar en gymnast ett poäng mellan ett och tio
        {
            int minScore = 0;
            int maxScore = 10;

            if (score < minScore || score > maxScore)
            {
                throw new ArgumentOutOfRangeException("Poängen är utanför det tillåtna poängintervallet 0-10");
            }

            gymnast.Score = score;
        }


        private int _allScored;

        public int AllScored
        {
            get { return _allScored; }
            set
            {
                if (IntLength(value) == 8)
                {
                    _allScored = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Du har inte poängsatt alla gymnaster");
                }
            }
        }          
             
        
        public static int IntLength(int i)
        {
            // Hittade på http://stackoverflow.com/a/22999111
            if (i < 0)
                throw new ArgumentOutOfRangeException();
            if (i == 0)
                return 1;
            return (int)Math.Floor(Math.Log10(i)) + 1;
        }

    }
}
