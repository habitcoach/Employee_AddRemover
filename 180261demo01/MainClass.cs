using demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180261demo01
{
    public class MainClass {

        public static void Main() {



            EmpService empService = new EmpService();

            //Read all employee
            Console.WriteLine("The list of employee is");


           var list= empService.GetEmployees();

            foreach (var emp in empService.GetEmployees())
            {

                Console.WriteLine(emp.Name + "   " + emp.Salary);

            }

            //Create new employee

            Employee newEmp = new Employee("NewEmp",15,1000);

            Console.WriteLine("employee addded: "+ empService.CreateEmployee(newEmp));


            Console.WriteLine("The list of updated employee is");

            foreach (var emp in empService.GetEmployees())
            {

                Console.WriteLine(emp.Name + "   " + emp.Salary);

            }

            //Update employee

            Employee newEmp02 = new Employee("Name01", 15, 20000);

            Console.WriteLine("employee updated: " + empService.UpdateEmployee(newEmp02));


            Console.WriteLine("The list of updated employee is");

            foreach (var emp in empService.GetEmployees())
            {

                Console.WriteLine(emp.Name +"   "+ emp.Salary);

            }

        }
    



    }
}
