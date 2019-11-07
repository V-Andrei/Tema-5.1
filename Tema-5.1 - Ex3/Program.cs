using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            {
                Worker w1 = new Worker("Badea", "Ion", 2000, 30);
                Worker w2 = new Worker("Ardeleanu", "Mircea", 3500, 46);
                Worker w3 = new Worker("Aciu", "Elena", 1500, 32);
                Worker w4 = new Worker("Enache", "Sorin", 1680, 20);
                Worker w5 = new Worker("Popescu", "Silvia", 1458, 27);
                Worker w6 = new Worker("Stefanescu", "Florin", 1000, 35);
                Worker w7 = new Worker("Sotir", "Andrei", 3000, 38);
                Worker w8 = new Worker("Olteanu", "Marian", 2888, 22);
                Worker w9 = new Worker("Voinicila", "Ion", 2356, 39);
                Worker w10 = new Worker("Popa", "Alexandru", 1999, 40);

                workers.Add(w1);
                workers.Add(w2);
                workers.Add(w3);
                workers.Add(w4);
                workers.Add(w5);
                workers.Add(w6);
                workers.Add(w7);
                workers.Add(w8);
                workers.Add(w9);
                workers.Add(w10);
            };

            Worker.SortByMoneyPerHourDescending(workers);

            List<Student> students = new List<Student>();
            {
                Student s1 = new Student("Lunca", "Eduard") { Grade = 2 };
                Student s2 = new Student("Mosoiu", "Ionita") { Grade = 8 };
                Student s3 = new Student("Jalba", "Vlad") { Grade = 2 };
                Student s4 = new Student("Ionescu", "Nicolae") { Grade = 7 };
                Student s5 = new Student("Maganu", "Mihai") { Grade = 3 };
                Student s6 = new Student("Dalba", "Simona") { Grade = 4 };
                Student s7 = new Student("Simon", "Serban") { Grade = 10 };
                Student s8 = new Student("Badie", "Roxana") { Grade = 9 };
                Student s9 = new Student("Rauschi", "Delia") { Grade = 2 };
                Student s10 = new Student("Machidon", "Constantin") { Grade = 10 };

                students.Add(s1);
                students.Add(s2);
                students.Add(s3);
                students.Add(s4);
                students.Add(s5);
                students.Add(s6);
                students.Add(s7);
                students.Add(s8);
                students.Add(s9);
                students.Add(s10);

            };
            IEnumerable<Student> query = students.OrderBy(Student => Student.Grade);

            foreach (Student student in query)
            {
                Console.WriteLine("{0} {1} - {2} ", student.FirstName, student.LastName, student.Grade);
            }


            List<dynamic> merged = new List<dynamic>(students.Concat<dynamic>(workers));

            var sortedMergedList =
                from human in merged
                orderby human.GetFirstName(), human.GetLastName()
                select human;
            Console.WriteLine("Merge list");

            foreach (var person in sortedMergedList)
            {
                Console.WriteLine(person.GetFirstName() + " " + person.GetLastName());
            }

            Console.ReadLine();
            
            

        }

    }
}
