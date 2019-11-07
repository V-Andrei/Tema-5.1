using System;

namespace Tema_5._1___Ex2
{
    class Frog : Animal
    {
        public Frog(int age, string name, Sex sex)
            : base(age, name, sex)
        { }

        public override void Sound()
        {
            Console.WriteLine("Oak, Oak!");
        }
    }
}
