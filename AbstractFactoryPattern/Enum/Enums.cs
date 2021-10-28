using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class Enums
    {
        public enum MachineType
        {
            Laptop,
            Desktop
        }

        public enum Processor
        {
           
            I5,
            I7
        }
        public enum Company
        {
            Hp,
            Apple
        }
        public enum EmployeeType
        {
            PartTime,
            FullTime
        }
        public enum JobDescription
        {
            Manager,
            NonManager
        }
    }
}
