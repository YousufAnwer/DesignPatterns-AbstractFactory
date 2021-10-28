using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryPattern.AbstractFactory.Enums;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class Desktop : IMachine
    {
        public string GetMachineType()
        {
            return MachineType.Desktop.ToString();
        }
    }
}
