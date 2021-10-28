using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryPattern.AbstractFactory.Enums;

namespace AbstractFactoryPattern.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public JobDescription JobDescription { get; set; }
        public string SystemInformation { get; set; }
        public Employee()
        {
                
        }
        public Employee(string name, EmployeeType employeeType, JobDescription jobDescription)
        {
            Name = name;
            EmployeeType = employeeType;
            JobDescription = jobDescription;
        }

    }
}
