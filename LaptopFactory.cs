using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternG1
{
    internal interface LaptopFactory
    {
        Laptop buildLaptop(string laptop);
    }
}
