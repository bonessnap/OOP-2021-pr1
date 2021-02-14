using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Nasledovanie
{
    class employer : human
    {
        public int sallary;
        public int tax;
        public override int Money()
        {
            return sallary - tax;
        }
    }
}
