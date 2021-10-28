using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.AbstractFactory.Repo;
using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repo = new EmployeeRepository();
            List<Employee> employeeList = new List<Employee>();
            var employees = repo.GetEmployees();

            foreach (var item in employees)
            {
                IComputerFactory computerFactory = new EmployeeSystemFactory().Create(item);
                EmployeeSystemManager employeeSystemManager = new EmployeeSystemManager(computerFactory);
                item.SystemInformation = employeeSystemManager.GetSystemDetails();
                employeeList.Add(item);

            }

            foreach (var item in employeeList)
            {
                repo.PrintEmpolyee(item);
            }
            Console.ReadLine();
        }
    }
}
