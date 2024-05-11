using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPreparation
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int AnnualSalaray { get; set; }
        public int DepartmentId {get; set;}
        public static List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();

            var emp1 = new Employee()
            {
                EmpId = 1,
                Name = "Govind",
                Gender = "Male",
                DepartmentId = 1,
              //  Department = "IT",
                AnnualSalaray = 120000
            };

            employees.Add(emp1);
            var emp2 = new Employee()
            {
                EmpId = 2,
                Name = "Selvi",
                Gender = "Female",
                DepartmentId = 3,
                // Department = "HR",
                AnnualSalaray = 45000
            };

            employees.Add(emp2);
            var emp3 = new Employee()
            {
                EmpId = 3,
                Name = "Dinesh",
                Gender = "Male",
                DepartmentId = 1,
                // Department = "IT",
                AnnualSalaray = 135000
            };

            employees.Add(emp3);
            var emp4 = new Employee()
            {
                EmpId = 4,
                Name = "Krishna",
                Gender = "Male",
                DepartmentId = 1,
                // Department = "IT",
                AnnualSalaray = 150000
            };

            employees.Add(emp4);
            var emp5 = new Employee()
            {
                EmpId = 5,
                Name = "Divya",
                Gender = "Female",
                DepartmentId = 3,
                // Department = "HR",
                AnnualSalaray = 35000
            };

            employees.Add(emp5);

            var emp6 = new Employee()
            {
                EmpId = 6,
                Name = "Muthu",
                Gender = "Male",
                DepartmentId = 3,
                // Department = "HR",
                AnnualSalaray = 35000
            };

            employees.Add(emp6);

            var emp7 = new Employee()
            {
                EmpId = 7,
                Name = "Poonkodi",
                Gender = "Female",
               
                // Department = "IT",
                AnnualSalaray = 35000
            };

            employees.Add(emp7);

            return employees;
        }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Department> GetAllDepartments()
        {
            var departments = new List<Department>();

            var debt1 = new Department() { Id = 1, Name = "IT" };
            var debt2 = new Department() { Id = 2, Name = "Payroll" };
            var debt3 = new Department() { Id = 3, Name = "HR" };

            departments.Add(debt1);
            departments.Add(debt2);
               departments.Add(debt3);
            return departments;
        }
    }
}
