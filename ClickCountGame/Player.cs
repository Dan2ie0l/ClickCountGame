using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCountGame
{
    public class Player : ICloneable
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Dictionary<int, int> results = new Dictionary<int, int>();


        public override string ToString()
        {
            return $"{FirstName},{LastName},{Age}";
        }
    }

}
