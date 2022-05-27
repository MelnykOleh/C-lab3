using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab3Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)
            WriteLine("1:");
            StudentCollection studentCollection = new StudentCollection();
            studentCollection.AddDefaults();
            studentCollection.AddStudents(new Student[] { new Student(new Person("Vitaliy", "Svurudenko", new DateTime(2002, 1, 17)), Education.SecondEducation, 301) { Exams = new List<Exam>() { new Exam("Math", 4, new DateTime(2022, 5, 29)), new Exam("Web", 5, new DateTime(2022, 6, 12)) }, Tests = new List<Test>() { new Test(), new Test("C#", false), new Test("Java", true) } }, new Student(new Person("Ivan", "Dmytrenko", new DateTime(2001, 08, 21)), Education.Master, 302) { Exams = new List<Exam>() { new Exam(), new Exam("Java", 3, new DateTime(2022, 6, 10)) }, Tests = new List<Test>() { new Test() } } });
            WriteLine(studentCollection.TypeEducation);
            WriteLine("|------------------------------------------------------------|\n");


            //2)
            WriteLine("2:");
            WriteLine("Sort by surname:\n");
            studentCollection.SortBySurname();
            WriteLine(studentCollection);
            WriteLine("Sort by date:\n");
            studentCollection.SortByDate();
            WriteLine(studentCollection);
            WriteLine("Sort by grade:\n");
            studentCollection.SortByGrade();
            WriteLine(studentCollection.ToShortString());
            WriteLine("|------------------------------------------------------------|\n");

            //3)
            WriteLine("3:");
            WriteLine("Max average grade");
            WriteLine(studentCollection.MaxGrade);
            WriteLine("Students with education Master");
            foreach (Student stud in studentCollection.TypeEducation)
            {
                WriteLine(stud);
            }
            WriteLine("Group students with mark");
            foreach (Student stud in studentCollection.AverageMarkGroup(4.5))
            {
                WriteLine(stud);
            }
            WriteLine("|------------------------------------------------------------|\n");

            //4)
            WriteLine("4:");
            TestCollections testCollection = new TestCollections(10000);
            testCollection.TimeFinding(10000);
            WriteLine("|------------------------------------------------------------|\n");

        }

    }
}
