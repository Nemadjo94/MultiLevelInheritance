using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    class Vehicle : Mode
    {
        public void Noise()
        {
            Console.WriteLine("Almost all vehicles create noice!");
        }

        public void Feature()
        {
            Console.WriteLine("They mainly help in traveling!");
        }
    }
}
