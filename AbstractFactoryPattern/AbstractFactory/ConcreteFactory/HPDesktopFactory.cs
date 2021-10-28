using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class HPDesktopFactory : IComputerFactory
    {
        public ICompany Company()
        {
            return new HP(); 
        }
        public IProcessor Processor()
        {
            return new I5();
        }
        public virtual IMachine Machine()
        {
            return new Desktop();
        }

       
    }
}
