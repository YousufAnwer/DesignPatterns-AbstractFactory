using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    //https://www.youtube.com/watch?v=z47aJGe7jR4   //https://youtu.be/z47aJGe7jR4?t=1340
    public class EmployeeSystemManager
    {
        IComputerFactory _computerFactory;
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            _computerFactory = computerFactory;
        }

        public string GetSystemDetails()
        {
            ICompany company = _computerFactory.Company();
            IProcessor processor = _computerFactory.Processor();
            IMachine machine = _computerFactory.Machine();
            string result = string.Format("{0} {1} {2}", company.GetCompany(), processor.GetProcessor(), machine.GetMachineType());
            return result;
        }
    }
}
