using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class HPLaptopFactory:HPDesktopFactory
    {
        public override IMachine Machine()
        {
            return new Laptop();
        }
    }
}
