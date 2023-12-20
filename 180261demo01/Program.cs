using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace demo
{
    public class Employee
    {

        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            Name = "defult name";
            Age = 0;
            Salary = 0;

        }

        public Employee(string name, int age,double salary)
        {
               this.Name = name;
            Age = age;
            Salary = salary;
        }

        public void GiveRaise(double percentage)
        {
            if (percentage < 0)
            {
                throw new ArgumentException("Percentage cannot be negative.");
            }

            double raiseAmount = Salary * (percentage / 100);

            Salary = Salary + raiseAmount;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Salary: $" + Salary);
        }


    }

   




}


