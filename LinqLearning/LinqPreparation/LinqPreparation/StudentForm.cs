using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqPreparation
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            SampledbmlDataContext dataContext = new SampledbmlDataContext();

            int[] numbers =  { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //dataGridViewStudent.AutoGenerateColumns = true;
            //dataGridViewStudent.DataSource = (from number in numbers
            //                                 where (number % 2) == 0
            //                                 select number).ToList();


            //dataGridViewStudent.DataSource = from student in dataContext.Students
            //                                 where student.Gender == "Male"
            //                                 select student;

           // SelectClause();

            //ExtensionMethod();

            //AggregateOperators();

            RestrictionOperator();

        }

        private void RestrictionOperator()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Func<int, bool> evnNums = new Func<int, bool>(isEven);

            var evenNumbers = numbers.Where((a,b)=> b==1);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

           var obj  = numbers.Select((a, b) => new { Number = a, Index = b });

            foreach (var num in obj)
            {
                Console.WriteLine(num.Number + " - " + num.Index);
            }
        }

        private bool isEven(int num)
        {
            return num % 2 == 0;
        }

        private void AggregateOperators()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] numbers2 = { 1, 2, 3, 4 ,5};

            string[] countries = { "India", "USA", "UK","Australia","Russia" };
            #region WithLinq
            //Min
            var min = numbers.Min();
            var min2 = numbers.Where(x => x % 2 == 0).Min();
            //Max
            var max = numbers.Max();
            var max2 = numbers.Where(num => num % 2 == 0).Max();
            //Avg
            var avg = numbers.Average();
            var avg2 = numbers.Where(num => num % 2 == 0).Average();
            //Sum
            var sum = numbers.Sum();
            var sum2 = numbers.Where(num => num % 2 == 0).Sum();
            //Count

            var count = numbers.Count();
            var count2 = numbers.Where(num => num % 2 == 0).Count();

           // Aggregate


            Console.WriteLine("Min - " + min.ToString());
            Console.WriteLine("Min of even numbers - " + min2.ToString());
            Console.WriteLine("Max - " + max2.ToString());
            Console.WriteLine("Max of even numbers - " + max.ToString());
            Console.WriteLine("Avg - " + avg.ToString());
            Console.WriteLine("Avg of even numbers - " + avg2.ToString());
            Console.WriteLine("Sum - " + sum.ToString());
            Console.WriteLine("Sum of even numbers - " + sum2.ToString());
            Console.WriteLine("Count - " + count.ToString());
            Console.WriteLine("Count of even numbers- " + count2.ToString());

          
            var length = countries.Min(x => x.Length);

            Console.WriteLine("The smallest length is {0} of the contries", length);

            //Aggregate

            var stringResult = countries.Aggregate((a, b) => a + ", " + b);

            var intResult = numbers2.Aggregate(10,(a, b) => a * b);

            Console.WriteLine("Aggregate number - Running product " + intResult);
            Console.WriteLine("Aggregate countries "+ stringResult);


            //  Console.WriteLine("Aggregate");

            #endregion

            #region Wihtout LINQ

            //int min = numbers[0];
            //foreach (var number in numbers)
            //{
            //    if (min > number)
            //    {
            //        min = number;
            //    }
            //}

            //int? min2 = null;
            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        if(!min2.HasValue || min2 > number)
            //        {
            //            min2 = number;
            //        }
            //    }
            //}

            //int max = numbers[0];
            //foreach (var number in numbers)
            //{
            //    if (max < number)
            //    {
            //        max = number;
            //    }
            //}

            //int max2 = numbers[0];
            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        if (max2 < number)
            //        {
            //            max2 = number;
            //        }
            //    }
            //}

            //double sum1 = 0;
            //int count1 = 0;
            //foreach(var number in numbers)
            //{
            //    sum1 += number;
            //    count1++;
            //}

            //double avg = sum1 / count1;

            //double sum3 = 0;
            //int count3 = 0;
            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        sum3 += number;
            //        count3++;
            //    }
            //}

            //double avg2 = sum3 / count3;

            //int sum = 0;

            //foreach (var number in numbers)
            //{
            //    sum += number;
            //}

            //int sum2 = 0;

            //foreach (var number in numbers)
            //{
            //    if(number % 2 == 0)
            //    sum2 += number;
            //}

            //int count = 0;
            //foreach (var number in numbers)
            //{
            //    count += 1;
            //}
            //int count2 = 0;
            //foreach (var number in numbers)
            //{
            //    count2 += 1;
            //}

            //Console.WriteLine("Min - " + min.ToString());
            //Console.WriteLine("Min of even numbers - " + min2.ToString());
            //Console.WriteLine("Max - " + max2.ToString());
            //Console.WriteLine("Max of even numbers - " + max.ToString());
            //Console.WriteLine("Avg - " + avg.ToString());
            //Console.WriteLine("Avg of even numbers - " + avg2.ToString());
            //Console.WriteLine("Sum - " + sum.ToString());
            //Console.WriteLine("Sum of even numbers - " + sum2.ToString());
            //Console.WriteLine("Count - " + count.ToString());
            //Console.WriteLine("Count of even numbers- " + count2.ToString());


            //int? length = null;
            //foreach (var country in countries)
            //{
            //    if(!length.HasValue || length > country.Length)
            //    {
            //        length = country.Length;
            //    }
            //}

            //Console.WriteLine("The smallest length is {0} of the contries", length);

            string country = string.Empty;
            foreach (var contry in countries)
            {
                country = country + contry + ",";
            }

            var lastIndex = country.LastIndexOf(",");

           var c=  country.Remove(lastIndex);

            Console.WriteLine(c);


            int number = 1;
            foreach (var num in numbers2)
            {
                number *= num;
            }

            Console.WriteLine(number);

            #endregion


        }

        private void ExtensionMethod()
        {
            var strName = "govind";

            var modified = strName.ChangeTheFirstCase();

            var another = ExtensionClass.ChangeTheFirstCase(strName);

            Console.WriteLine(another);


            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};

           // var evenNumbers = numbers.Where(num => num % 2 == 0).ToList();

            var evenNumbers = Enumerable.Where(numbers,num => num % 2 == 0).ToList();

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
           
        }

        private void SelectClause()
        {
            //Lambda Expression
            IEnumerable<StudentClass> maleStudents = StudentClass.GetAllStudents().Where(student => student.Gender == "Male");

           // dataGridViewStudent.DataSource = maleStudents.ToList();

            //Sql like expression

            IEnumerable<StudentClass> femaleStudents = from student in StudentClass.GetAllStudents()
                                                       where student.Gender == "Female"
                                                       select student;

            dataGridViewStudent.DataSource = femaleStudents.ToList();
        }
    }
}
