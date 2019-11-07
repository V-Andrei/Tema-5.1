using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5._1___Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] cats = new Cat[4];
            Cat cat1 = new Cat(4, "Tiger", Cat.Sex.female);
            Cat cat2 = new Cat(2, "Max", Cat.Sex.male);
            Kitten kitty = new Kitten(4, "Kitty");
            Tomcat tomcat = new Tomcat(6, "Tom");

            cats[0] = cat1;
            cats[1] = cat2;
            cats[2] = kitty;
            cats[3] = tomcat;
            Console.WriteLine("Cats averge age is: ");
            Console.WriteLine(Animal.AverageAge(cats));

            Frog[] frogs = new Frog[4];
            Frog f1 = new Frog(10, "Froxi", Frog.Sex.female);           
            Frog f2 = new Frog(8, "Ribbit", Frog.Sex.male);
            Frog f3 = new Frog(6, "Edward", Frog.Sex.female);
            Frog f4 = new Frog(12, "Mr.Toad", Frog.Sex.male);

            frogs[0] = f1;
            frogs[1] = f2;
            frogs[2] = f3;
            frogs[3] = f4;
            Console.WriteLine("Frogs averge age is: ");
            Console.WriteLine(Animal.AverageAge(frogs));


            Dog[] dogs = new Dog[5];
            Dog d1 = new Dog(7, "Sharo", Animal.Sex.male);            
            Dog d2 = new Dog(20, "Rex", Animal.Sex.male);
            Dog d3 = new Dog(8, "Balkan", Animal.Sex.male);
            Dog d4 = new Dog(14, "Lasi", Animal.Sex.female);
            Dog d5 = new Dog(18, "Kari", Animal.Sex.female);
            dogs[0] = d1;
            dogs[1] = d2;
            dogs[2] = d3;
            dogs[3] = d4;
            dogs[4] = d5;

            Console.WriteLine("Dogs averge age is: ");
            Console.WriteLine(Animal.AverageAge(dogs));

            Console.ReadLine();
        }
    }
}
