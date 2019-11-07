using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5._1___Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Andre");

            List<Discipline> subjects = new List<Discipline>();
            Discipline d1 = new Discipline("History", 4, 3);
            Discipline d2 = new Discipline("Math", 3, 2);
            subjects.Add(d1);
            subjects.Add(d2);


            Teacher t = new Teacher("George", subjects);
            Teacher[] teacher = new Teacher[1];
            teacher[0] = t;

            Student st1 = new Student("Popa Alexandra", 21);
            Student st2 = new Student("Ionescu Serban", 4, "He hate the histroy");
            Student st3 = new Student("Nicolae Petre", 8);
            Student[] students = new Student[3];
            students[0] = st1;
            students[1] = st2;
            students[2] = st3;
            MyClass firstClass = new MyClass(teacher, students, "10A");
            Console.WriteLine("Test: " + st2.Name + " " + st1.ClassNumber + " " + st2.Comment);

            School testClass = new School(students);

            Console.ReadLine();
        }
    }

}
