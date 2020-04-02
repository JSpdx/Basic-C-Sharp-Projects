using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    class Ranger
    {
        public Ranger(string name) : this(name, 1)
        {
        }
        public Ranger(string name, int level)
        {
            Level = level;
            Name = name;

        }
        public int Level { get; set; }
        public  string Name { get; set; }

    }
}
