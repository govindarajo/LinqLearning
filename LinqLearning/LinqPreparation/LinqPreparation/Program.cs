using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StudentForm form = new StudentForm();

            //form.ShowDialog();

            //ProjectionOperators();

            // OrderingOperators();

            // PartitioningOpertors();

            //PagingApplicationUsingTakeAndSkip();

            //ConversionOperators();

            // GroupingOperators();

            //ElementOperators();

            GroupJoin();
        }

        private static void GroupJoin()
        {
            //var joinByDepartmentId = Department.GetAllDepartments()
            //                        .GroupJoin(Employee.GetAllEmployees(),
            //                        d => d.Id,
            //                        e => e.DepartmentId,
            //                        (department, employee) =>
            //                        new
            //                        {
            //                            department,
            //                            employee
            //                        });
            //foreach (var department in joinByDepartmentId)
            //{
            //    Console.WriteLine(department.employee.Name);
            //    Console.WriteLine("-----------");
            //    foreach (var emp in department.department)
            //    {
            //        Console.WriteLine(emp.Name);
            //    }

            //    Console.WriteLine();
            //}

            //var joinByDepartmentId = Employee.GetAllEmployees()
            //                        .GroupJoin(Department.GetAllDepartments(),
            //                        e=>e.DepartmentId,
            //                        d=> d.Id,
            //                        (employee, department) =>
            //                        new
            //                        {
            //                            employee,
            //                            department
            //                        });
            //foreach (var department in joinByDepartmentId)
            //{
            //    Console.WriteLine(department.employee.Name);
            //    Console.WriteLine("-----------");
            //    foreach (var emp in department.department)
            //    {
            //        Console.WriteLine(emp.Name);
            //    }

            //    Console.WriteLine();

            //var joinByDepartmentId = from debt in Department.GetAllDepartments()
            //                         join emp in Employee.GetAllEmployees()
            //                         on debt.Id equals emp.DepartmentId into eGroup
            //                         select new
            //                         {
            //                             Department = debt,
            //                             Employees = eGroup
            //                         };

            //foreach (var department in joinByDepartmentId)
            //{
            //    Console.WriteLine(department.Department.Name);
            //    Console.WriteLine("-----------");
            //    foreach(var emp in department.Employees)
            //    {
            //        Console.WriteLine(emp.Name);
            //    }

            //    Console.WriteLine();
            //}


            //Inner Join

            //var joinByDepartmentId = from d in Department.GetAllDepartments()
            //                         join e in Employee.GetAllEmployees()
            //                         on d.Id equals e.DepartmentId
            //                         select new
            //                         {
            //                             EmployeeName = e.Name,
            //                             DepartmentName = d.Name
            //                         };

            //foreach (var item in joinByDepartmentId)
            //{
            //     Console.WriteLine(item.EmployeeName +"\t"+ item.DepartmentName);
            //}

            //var joinByDepartmentId = Employee.GetAllEmployees().Join(Department.GetAllDepartments(),
            //                                                    e => e.DepartmentId,
            //                                                    d => d.Id,
            //                                                    (employee, department) => new
            //                                                    {
            //                                                        EmployeeName = employee.Name,
            //                                                        DepartmentName = department.Name
            //                                                    });

            //foreach (var item in joinByDepartmentId)
            //{
            //    Console.WriteLine(item.EmployeeName + "\t" + item.DepartmentName);
            //}

            //LeftOuter Join

            //var leftOuterJoin = Employee.GetAllEmployees()
            //                                .GroupJoin(Department.GetAllDepartments(),
            //                                                d => d.DepartmentId,
            //                                                e => e.Id,
            //                                                (employee, department) => new
            //                                                {
            //                                                    Employees = employee,
            //                                                    Department = department
            //                                                })

            //                                .SelectMany(z => z.Department.DefaultIfEmpty(),
            //                                (emp, dept) => new
            //                                {
            //                                    EmployeeName = emp.Employees.Name,
            //                                    DepartmentName = dept==null ? "No Department":dept.Name
            //                                });        

            //foreach(var item in leftOuterJoin)
            //{
            //    Console.WriteLine(item.EmployeeName + "\t"+ item.DepartmentName);
            //}

            //Cross join

            //var result = Employee.GetAllEmployees().SelectMany(e => Department.GetAllDepartments(),
            //                                         (e, d) =>new  { e,d}) ; 
            //foreach(var e in result)
            //{
            //    Console.WriteLine(e.e.Name + "\t" + e.d.Name);
            //}

            //var result = from e in Department.GetAllDepartments() 
            //             from d in Employee.GetAllEmployees()
            //             select new
            //             {
            //                 e,
            //                 d
            //             };
            //foreach (var d in result)
            //{
            //    Console.WriteLine(d.e.Name +"\t"+d.d.Name);
            //}

            //MYdoubt test

            var result = Employee.GetAllEmployees().SelectMany(e => Department.GetAllDepartments(),
                                                                (emp, debt) => new {emp,debt});

            foreach(var e in result)
            {
                Console.WriteLine(e.emp.Name+"\t"+e.debt.Name);
            }
        }

        private static void ElementOperators()
        {
            //First -1

            //int[] numbers = { 1, 2, 3, 4 };

            //var result = numbers.First();

            //Console.WriteLine(result);

            ////2 -EXception
            //int[] numbers = {  };

            //var result = numbers.First();

            //Console.WriteLine(result);


            ////FirstOrDefault
            //int[] numbers = { };

            //var result = numbers.FirstOrDefault();

            //Console.WriteLine(result);

            ////FirstOrDefault
            //int[] numbers = { 1, 2, 3, 4 };

            //var result = numbers.FirstOrDefault();

            //Console.WriteLine(result);


            ////Second overloaded method for first/FirstOrDefault

            //int[] numbers = { 1, 2, 3, 4 };

            //var result = numbers.FirstOrDefault(x=>x%2==0);

            //Console.WriteLine(result);

            //Second overloaded method for first/FirstOrDefault

            //int[] numbers = { };

            //var result = numbers.First(x => x % 2 == 0);

            //Console.WriteLine(result);

            ////Last
            ////LastOrDefalut are as like First() but with the last element


            ////Single

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var n = numbers.Single();
            //Console.WriteLine(n);

            //Single

            //int[] numbers = { 1, 2, 3};

            //var n = numbers.Single(x => x % 2 == 0);
            //Console.WriteLine(n);

            ////Default if empty

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var n = numbers.DefaultIfEmpty();

            //foreach(var i in n)
            //{
            //    Console.WriteLine(i);
            //}

            //Default if empty

            //int[] numbers = {  };

            //var n = numbers.DefaultIfEmpty();

            //foreach (var i in n)
            //{
            //    Console.WriteLine(i);
            //}

            //Default if empty

            int[] numbers = {  };

            var n = numbers.DefaultIfEmpty(15);

            foreach (var i in n)
            {
                Console.WriteLine(i);
            }

        }

        private static void GroupingOperators()
        {
            var employeeList = Employee.GetAllEmployees();

            //var employeeGroupByDept = employeeList.GroupBy(x => x.Department);

            // foreach( var employee in employeeGroupByDept)
            // {
            //     //Console.WriteLine("{0} - {1}", employee.Key, employee.Count(x=>x.Gender =="Male"));
            //     //Console.WriteLine("{0} - {1}", employee.Key, employee.Max(x=>x.AnnualSalaray));

            //     Console.WriteLine("{0} - {1}", employee.Key, employee.Count());
            //     Console.WriteLine("-------------");
            //     foreach(var emp in employee)
            //     {
            //         Console.WriteLine(emp.Name);
            //     }
            // }

            //var employeeGroupByDept = from emp in employeeList
            //                          group emp by emp.Department into eGroup
            //                          orderby eGroup.Key descending
            //                          select new
            //                          {
            //                              eGroup.Key,
            //                              Employees = eGroup.OrderBy(x=>x.Name)
            //                          };


            //var employeeGroupByDept = employeeList.GroupBy(x => x.Department,(key,g)=>  new
            //{
            //    Key = key,
            //    Employees = g.OrderBy(x=>x.Name)
            //}       
            //);



            //foreach (var employee in employeeGroupByDept)
            //{
            //    //Console.WriteLine("{0} - {1}", employee.Key, employee.Count(x=>x.Gender =="Male"));
            //    //Console.WriteLine("{0} - {1}", employee.Key, employee.Max(x=>x.AnnualSalaray));

            //    Console.WriteLine("{0} - {1}", employee.Key, employee.Employees.Count());
            //    Console.WriteLine("-------------");
            //    foreach (var emp in employee.Employees)
            //    {
            //        Console.WriteLine(emp.Name);
            //    }

            //    Console.WriteLine();
            //}




            //Using lookup
            //var employeeGroupusingLookup = employeeList.ToLookup(x => x.Department);

            //foreach (var employee in employeeGroupusingLookup)
            //{
            //    //Console.WriteLine("{0} - {1}", employee.Key, employee.Count(x=>x.Gender =="Male"));
            //    //Console.WriteLine("{0} - {1}", employee.Key, employee.Max(x=>x.AnnualSalaray));

            //    Console.WriteLine("{0}", employee.Key);
            //    Console.WriteLine("-------------");
            //    foreach (var emp in employeeGroupusingLookup[employee.Key])
            //    {
            //        Console.WriteLine(emp.Name);
            //    }

            //    Console.WriteLine();
            //}


            //Groupby using multiple keys

            //var result =  employeeList.GroupBy(x => new { x.Department, x.Gender })
            //            .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
            //            .Select(g => new
            //            {
            //                Key = g.Key,
            //                Department = g.Key.Department,
            //                Gender = g.Key.Gender,
            //                Employees = g.OrderBy(x=>x.Name)
            //            });

            //foreach(var g in result)
            //{
            //    Console.WriteLine("{0} Department {1} Employees count {2}", g.Key.Department, g.Gender,g.Employees.Count());
            //    Console.WriteLine("------------------------------------------------------");
            //    foreach(var emp in g.Employees)
            //    {
            //        Console.WriteLine(emp.Name +"\t"+ emp.Department);
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine();
            //}


            //var result = from employee in employeeList
            //             group employee by new { employee.Department, employee.Gender } into eGroup
            //             orderby eGroup.Key.Department, eGroup.Key.Gender
            //             select new
            //             {
            //                 Key = eGroup.Key,
            //                 Department = eGroup.Key.Department,
            //                 Gender = eGroup.Key.Gender,
            //                 Employees = eGroup.OrderBy(x => x.Name)
            //             };

            //foreach (var g in result)
            //{
            //    Console.WriteLine("{0} Department {1} Employees count {2}", g.Key.Department, g.Gender, g.Employees.Count());
            //    Console.WriteLine("------------------------------------------------------");
            //    foreach (var emp in g.Employees)
            //    {
            //        Console.WriteLine(emp.Name + "\t" + emp.Department);
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
        }

        private static void ConversionOperators()
        {
            ////toList()

            //string[] countries = { "India", "Australia", "UK", "US" };

            //var result = countries.ToList();

            //foreach(var country in countries)
            //{
            //     Console.WriteLine(country);
            //}

            ////ToArray

            //var countryList = new List<string>() { "India", "Australia", "UK", "US" };

            //var result2 = countryList.ToArray();

            //foreach (var country in result2)
            //{
            //    Console.WriteLine(country);
            //}

            //var result3 = (from country in countryList
            //              select country).ToArray();

            //foreach (var country in result3)
            //{
            //    Console.WriteLine(country);
            //}

            //ToDictionary

            var students = StudentClass.GetAllStudents();

            //var dict = students.ToDictionary(x => x.Id);

            //foreach(KeyValuePair<int,StudentClass> kvp in dict)
            //{
            //    Console.WriteLine(kvp.Key+" \t " + kvp.Value.Name);
            //}

            //var dict = students.ToDictionary(x => x.Id, x=>x.Name);

            //foreach (var kvp in dict)
            //{
            //    Console.WriteLine(kvp.Key + " \t " + kvp.Value);
            //}

            ////ToLookUp

            //var employeesGenderBased = students.ToLookup(x => x.Gender);

            //foreach(var kvp in employeesGenderBased)
            //{
            //    Console.WriteLine(kvp.Key);

            //    foreach(var emp in employeesGenderBased[kvp.Key])
            //    {
            //        Console.WriteLine(emp.Name + "\t"+ emp.Gender + "\t" + emp.Id);
            //    }
            //}

            //Cast and OfType

            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Add("a");

            //var convertedList = list.Cast<int>();

            //foreach(var n in convertedList)
            //{
            //    Console.WriteLine(n);
            //}

            //var convertedList = list.OfType<int>();

            //foreach (var n in convertedList)
            //{
            //    Console.WriteLine(n);
            //}


            //AsEnumerable

            SampledbmlDataContext dbContext = new SampledbmlDataContext();

            var studnt = dbContext.Students.AsQueryable().Where(s => s.Gender == "Male").Take(2);
                         

                       
            foreach(var s in studnt)
            {
                Console.WriteLine(s.Name);
            }
        }

        private static void PagingApplicationUsingTakeAndSkip()
        {
            var students = StudentClass.GetAllStudents();

            do
            {
                Console.WriteLine("Please Enter the Page Number from 1 to 2");
                int pageNumber = 0;

                if (int.TryParse(Console.ReadLine(), out pageNumber))
                {
                    if (pageNumber > 0 && pageNumber < 3)
                    {
                        int pageSize = 3;

                        var list = students.Skip((pageNumber - 1) * pageSize).Take(pageSize);

                        foreach (var s in list)
                        {
                            Console.WriteLine(s.Name);
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("Please Enter the Page Number from 1 to 2");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter the Page Number from 1 to 2");
                }
            } while (true);
                
        }

        private static void PartitioningOpertors()
        {
            string[] countries = { "Australia", "India", "England", "US", "UK", "Netherland", "Pakistan", "Bangladesh" };

            //var list = countries.Take(4);

            //foreach( var country in list )
            //{
            //    Console.WriteLine(country);
            //}

            //var list = (from country in countries
            //           select country).Take(4);

            //foreach (var country in list)
            //{
            //    Console.WriteLine(country);
            //}

            //var list = (from country in countries
            //            select country).Skip(4);

            //foreach (var country in list)
            //{
            //    Console.WriteLine(country);
            //}

            //var list = countries.Skip(4);

            //foreach (var country in list)
            //{
            //    Console.WriteLine(country);
            //}

            //var list = countries.TakeWhile(str => str.Length > 2);

            //foreach (var country in list)
            //{
            //    Console.WriteLine(country);
            //}
            var list = countries.SkipWhile(str => str.Length > 2);

            foreach (var country in list)
            {
                Console.WriteLine(country);
            }
        }

        private static void OrderingOperators()
        {
            var students = StudentClass.GetAllStudents();

            //var result = students.OrderByDescending(stu => stu.TotalMarks).ThenBy(s => s.Id);

            //foreach (var student in result)
            //{
            //    Console.WriteLine(student.TotalMarks + "\t " + student.Name + "\t" + student.Id);
            //}


            //var result = from student in students
            //             orderby student.TotalMarks descending,student.Id descending
            //             select student;

            students.Reverse();

            foreach (var student in students)
            {
                Console.WriteLine(student.TotalMarks + "\t " + student.Name + "\t" + student.Id);
            }
        }

        private static void ProjectionOperators()
        {
            IEnumerable<int> empIdList = Employee.GetAllEmployees().Select(emp => emp.EmpId);

            foreach (var emp in empIdList)
            {
                Console.WriteLine(emp);
            }

            //var empList = Employee.GetAllEmployees().Select(emp => new {Name = emp.Name, Gender = emp.Gender });

            //foreach (var emp in empList)
            //{
            //    Console.WriteLine(emp.Name + " - "+emp.Gender);
            //}

            //var empList = Employee.GetAllEmployees().Select(emp => new { Name = emp.Name, Gender = emp.Gender, MonthlySalary = emp.AnnualSalaray/12 });

            //foreach (var emp in empList)
            //{
            //    Console.WriteLine(emp.Name + " - " + emp.Gender + " Salary - "+emp.MonthlySalary);
            //}

            var empList = Employee.GetAllEmployees().Where(emp=>emp.AnnualSalaray >100000).
                Select(emp => new
                { 
                    Name = emp.Name, 
                    Gender = emp.Gender,
                    Bonus = emp.AnnualSalaray * .1
                });

            //foreach (var emp in empList)
            //{
            //    Console.WriteLine(emp.Name + " - " + emp.Gender+" Bonus - " + emp.Bonus);
            //}


            //SelectMany

            var subList = StudentClass.GetAllStudents().SelectMany(stu => stu.Subjects,(student,subject)=>
                                                                               new { student.Name, subject } );

            foreach (var student in subList)
            {
                Console.WriteLine(student.Name + " - "+ student.subject);
            }

            //foreach (var subject in subList)
            //{
            //    Console.WriteLine(subject);
            //}



            //string[] strList = { "ABCDEFGHIJKLMNOPQRSTUVWXYZ","9876" };

            //var strListMod = strList.SelectMany(str => str);

            //var selectCollection = strList.Select(str => str);

            //foreach (var str in strListMod)
            //{
            //    Console.WriteLine(str);
            //}

            //foreach (var str in selectCollection)
            //{
            //    foreach (var s in str)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
        }
    }
}
