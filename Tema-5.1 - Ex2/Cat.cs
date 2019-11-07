using System;

namespace Tema_5._1___Ex2
{
    public class Cat : Animal
    {

        public Cat(int age, string name, Sex sex)
             : base(age, name, sex)
        { 
        
        }

        public override void Sound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
