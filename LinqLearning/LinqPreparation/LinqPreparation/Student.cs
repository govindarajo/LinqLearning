using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPreparation
{
    public class StudentClass
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Gender { get; set; }

        public int TotalMarks { get; set; }
        public List<string> Subjects { get; set; }

        public static List<StudentClass> GetAllStudents()
        {
            var students = new List<StudentClass>();

            var student1 = new StudentClass()
            {
                Id = 1,
                Name = "Govind",
                Gender = "Male",
                TotalMarks = 422,
                Subjects = new List<string>() { "C#","C++"}
            };

            students.Add(student1);

            var student2 = new StudentClass()
            {
                Id = 2,
                Name = "Selvi",
                Gender = "Female",
                TotalMarks = 360,
                 Subjects = new List<string>() { "C#", "C++","HTML","C" }
            };

            students.Add(student2);

            var student3 = new StudentClass()
            {
                Id = 3,
                Name = "Dinesh",
                Gender = "Male",
                TotalMarks = 450,
                Subjects = new List<string>() { "Java", "JavaScript","Azure" }
            };

            students.Add(student3);

            var student4 = new StudentClass()
            {
                Id = 4,
                Name = "Indhu",
                Gender = "Female",
                TotalMarks = 350,
                Subjects = new List<string>() { "Java", "JavaScript", "Azure","Python" }
            };

            students.Add(student4);

            var student5 = new StudentClass()
            {
                Id = 5,
                Name = "Krishna",
                Gender = "Male",
                TotalMarks = 400
            };

            students.Add(student5);

            var student6 = new StudentClass()
            {
                Id = 6,
                Name = "Govind",
                Gender = "Male",
                TotalMarks = 422,
                Subjects = new List<string>() { "C#", "C++" }
            };
            students.Add(student6);
            return  students;
        }
    }
}
