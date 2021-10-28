using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryPattern.AbstractFactory.Enums;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processor.I7.ToString();
        }
    }
}
