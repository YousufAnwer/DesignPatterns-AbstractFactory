using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryPattern.AbstractFactory.Enums;

namespace AbstractFactoryPattern.AbstractFactory.Repo
{
    public class EmployeeRepository
    {
         List<Employee> employeeList { get; set; }
        public EmployeeRepository()
        {
            employeeList = new List<Employee>();

            employeeList.Add(new Employee("Yousuf", EmployeeType.FullTime, JobDescription.Manager));
            employeeList.Add(new Employee("Yasoob", EmployeeType.PartTime, JobDescription.Manager));
            employeeList.Add(new Employee("Ali", EmployeeType.FullTime, JobDescription.NonManager));
            employeeList.Add(new Employee("Sara", EmployeeType.PartTime, JobDescription.NonManager));
        }

        public List<Employee> GetEmployees()
        {
            return employeeList;
        }
        public void PrintEmpolyee(Employee item)
        {
            string result = string.Format("{0} {1} {2} {3} ", item.Name, item.JobDescription, item.EmployeeType, item.SystemInformation);
            Console.WriteLine(result);
        }
    }
}
