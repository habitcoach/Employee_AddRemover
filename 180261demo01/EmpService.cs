using demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180261demo01
{
    public class EmpService
    {

        List<Employee> list = new List<Employee>() {
                new Employee("Name01", 25, 10000),
                new Employee("Name02", 65, 2000) ,
                new Employee("Name03", 35, 3000) ,
                new Employee("Name04", 15, 4000) ,
                new Employee("Name05", 25, 5000) ,
            };
        public List<Employee> GetEmployees()
        {
            return list;

        }

        public bool CreateEmployee(Employee empoyee) { 
        
            list.Add(empoyee);

            return true;
        
        }

        public bool UpdateEmployee(Employee empoyee)
        {

            var existingEmp = list.Find(x => x.Name == empoyee.Name);

            existingEmp.Salary = empoyee.Salary;

           

            return true;

        }
    }
}
