using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnanymousMethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfEmployees = new List<Employee>();
            listOfEmployees.Add(new Employee("Govind", 1));
            listOfEmployees.Add(new Employee("Dinesh", 2));
            listOfEmployees.Add(new Employee("Divya", 2));

            // Predicate<Employee> predicate = new Predicate<Employee>(GetEmployee);

            //Ananymouse method
            //var emp = listOfEmployees.Find(delegate (Employee employee) { return employee.Id == 1; });



            // Lambda Expressions

            //var emp = listOfEmployees.Find(employee => employee.Id == 1);
            var empCount = listOfEmployees.Count(employee => employee.Name.StartsWith("D"));

            Console.WriteLine("Employee count starts with D -" + empCount);
            //Console.WriteLine("Name is -" + emp.Name + "," + "Id - " + emp.Id);

        }

        //private static bool GetEmployee(Employee emp)
        //{
        //    return emp.Id == 1;
        //}
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Employee(string name,int id)
        {
            Name = name;
            Id = id;
                 
        }
    }
}
