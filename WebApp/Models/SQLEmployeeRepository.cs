using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;
        public SQLEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }
        public void Edit(Employee employee)
        {
            context.Employees.Update(employee);
            context.SaveChanges();
        }

        public Employee GetEmployee(int Id)
        {
            return context.Employees.Find(Id);
        }
        //public List<Employee> GetEmployee()
        //{
        //}

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = context.Employees.ToList();
            return employees;
        }
    }
}
