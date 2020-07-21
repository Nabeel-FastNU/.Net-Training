using System;
using System.Collections.Generic;
using System.Linq;
using StudentTotal; 
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    class Program
    {
        static void Main(string[] args)
        {

            LambdaExpressions e = new LambdaExpressions();

            e.Signature();
            e.Print(e.Add(22, 45));

            List<string> animalNames = new List<string>
                 {"fawn", "gibbon", "heron", "ibex", "jackalope"};

            var longAnimalNames =
                from name in animalNames
                where name.Length >= 5
                orderby name.Length
                select name;

            Console.WriteLine(longAnimalNames.First());

            longAnimalNames.ToList().ForEach(o => Console.WriteLine(o));


            List<Student> students = new List<Student>();
            students.Add(new Student("Ali", 70));
            students.Add(new Student("Aslam", 40));
            students.Add(new Student("Nabeel", 30));
            students.Add(new Student("Heem", 90));
            students.Add(new Student("Ibraheem", 70));
            students.Add(new Student("Fazal Din", 45));
            students.Add(new Student("Reham Ali", 65));


            var sortedList = students.OrderByDescending(s => s.Marks).Select(x => new StudentTotal.StudentTotal
            {
                studentName = x.Name, TotalMarks = x.Marks
            }
            ).ToList();

            Console.WriteLine("\nSorted Students: ");

            sortedList.ForEach(s => { Console.Write(s.studentName + " "); Console.WriteLine(s.TotalMarks); });

            Console.WriteLine("\nPass Students: ");

            students.ForEach(s =>
            {
                if (s.Marks > 50)
                {
                    Console.WriteLine(s.Name);
                }
            }
            );

            var failStudents =
                from student in students
                where student.Marks < 50
                select student.Name;

            Console.WriteLine("\nFail Students: ");

            failStudents.ToList().ForEach(s => Console.WriteLine(s));

            students.ForEach(s => Console.WriteLine(s.checkPass(s)));

            students.ForEach(s => Console.WriteLine(s.isFailed()));

        }
    }
}
