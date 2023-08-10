using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id=1, Name="Tarun", Email="abc@gmail.com", Department="IT"},
                new Employee() {Id=2, Name="Rathore", Email="def@gmail.com", Department="HR"},
                new Employee() {Id=3, Name="Annu", Email="annu@gmail.com", Department="Admin"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public void Edit(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int Id)
        {
            return this._employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
