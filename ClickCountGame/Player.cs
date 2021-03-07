using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCountGame
{
     public  class Player
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public int Time { get; set; }

        public override string ToString()
        {
            return $"{FirstName},{LastName},{Age},{Score},{Time}";
        }
    }

}
