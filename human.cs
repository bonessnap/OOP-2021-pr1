using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Nasledovanie
{
    abstract class human
    {
        public override string ToString()
        {
            return name + " " + GetType().Name;
        }
        public string name;
        public abstract int Money();
    }

}
