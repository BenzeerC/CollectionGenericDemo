using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenericDemo
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public string EmpDesignation { get; set; }

    }

    public class EmployeeCRUD
    {
        private List<Employee> employees;

        public EmployeeCRUD()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee emp)//Add Employee
        {
            employees.Add(emp);
        }

        public List<Employee> GetEmployees()//Display Employee
        {
            return employees; 
        }

        public void UpdateEmployee(Employee emp)
        {
            foreach (Employee e in employees)
            {
                if(e.EmpId == emp.EmpId)
                {
                    e.EmpName = emp.EmpName;
                    e.EmpSalary = emp.EmpSalary;
                    e.EmpDesignation = emp.EmpDesignation;
                    break;
                }
            }
        }
        public void DeleteEmployee(int id)
        {
            foreach(Employee e in employees)
            {
                if(e.EmpId == id)
                {
                    employees.Remove(e);
                    break;
                }
            }
        }
    }
}
