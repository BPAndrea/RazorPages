using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RazorPages.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id= 1, Name = "Pap Dani", Department = Dept.IT, Email = "rosszdani@gmail.com", PhotoPath = "Boy2.jpg"},
                new Employee(){Id= 2, Name = "Okoska Dani", Department = Dept.HR, Email = "dani@gmail.com", PhotoPath = "Dani1.jpg"},
                new Employee(){Id= 3, Name = "BP Andi", Department = Dept.Payroll, Email = "andi@gmail.com", PhotoPath = "girl2.jpg"},
                new Employee(){Id= 4, Name = "Kis Ördög", Department = Dept.Other, Email = "dreamdani@gmail.com"},
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
