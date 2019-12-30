using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPages.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id= 1, Name = "Rossz Dani", Department = Dept.IT, Email = "rosszdani@gmail.com", PhotoPath = ""},
                new Employee(){Id= 2, Name = "Közepesen Rossz Dani", Department = Dept.HR, Email = "dani@gmail.com", PhotoPath = ""},
                new Employee(){Id= 3, Name = "Egész jó Dani", Department = Dept.Payroll, Email = "jodani@gmail.com", PhotoPath = ""},
                new Employee(){Id= 4, Name = "Ilyen jó nem létezik Dani", Department = Dept.Other, Email = "dreamdani@gmail.com", PhotoPath = ""},
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
