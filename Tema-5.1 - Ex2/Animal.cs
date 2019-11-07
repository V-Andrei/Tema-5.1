using System.Linq;

namespace Tema_5._1___Ex2
{
    public class Animal : ISound
    {
        public enum Sex { male, female}

        protected int age { get; set; }
        protected string name { get; set; }
        protected Sex sex { get; set; }

        public Animal(int age, string name, Sex sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }

        public Sex GetSex
        {
            get { return this.sex; }
        }

        public virtual void Sound()
        {
        }

        public static double AverageAge(Animal[] animals)
        {
            var average =
                from animal in animals
                select animal.age;
            double averageAge = average.Average();
            return averageAge;
        }
    }
}
