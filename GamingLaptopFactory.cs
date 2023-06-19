using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternG1
{
    internal class GamingLaptopFactory : LaptopFactory 
    {
        public Laptop buildLaptop(String laptop)
        {
            switch (laptop)
            {
                case "asus":
                    return new AsusRog();
                case "dell":
                    return new DellAlienware();
                default:
                    return null;
            }
        }
    }
}
