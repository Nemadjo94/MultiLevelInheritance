using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    class Program : Vehicle
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.mode();
            p.Noise();
            p.Feature();
        }
    }
}
