 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class MACDesktopFactory : IComputerFactory
    {
        public ICompany Company()
        {
            return new  MAC();
        }

        public  IProcessor Processor()
        {
            return new I7();
        }
        public virtual IMachine Machine()
        {
            return new Desktop();
        }
    }
}
