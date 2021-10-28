using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryPattern.AbstractFactory.Enums;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee employee)
        {
            IComputerFactory computerFactory = null;
            if (employee.JobDescription.Equals(JobDescription.Manager))
            {
                if (employee.EmployeeType.Equals(EmployeeType.FullTime))
                {
                    computerFactory = new MACLaptopFactory();
                }
                else
                {
                    computerFactory = new MACDesktopFactory();
                }
            }
            else if (employee.JobDescription.Equals(JobDescription.NonManager))
            {
                if (employee.EmployeeType.Equals(EmployeeType.FullTime))
                {
                    computerFactory = new HPLaptopFactory();
                }
                else
                {
                    computerFactory = new HPDesktopFactory();
                }
            }

            return computerFactory;
        }
    }
}
