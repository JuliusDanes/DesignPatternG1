using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternG1
{
    internal class OfficeLaptopFactory : LaptopFactory 
    {
        public Laptop buildLaptop(String laptop)
        {
            switch (laptop)
            {
                case "asus":
                    return new AsusVivoBook();
                case "dell":
                    return new DellLatitude();
                default:
                    return null;
            }
        }
    }
}
