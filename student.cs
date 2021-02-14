using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Nasledovanie
{
    class student : human
    {
        public int score;
        public override int Money()
        {
            if (score > 4)
                return 500;
            else return 0;
        }
    }
}
