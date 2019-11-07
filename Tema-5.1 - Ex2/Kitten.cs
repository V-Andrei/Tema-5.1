namespace Tema_5._1___Ex2
{
    class Kitten : Cat
    {
        public Kitten(int age, string name)
            : base(age, name, Sex.female)
        { }

        public Sex GetGender
        {
            get { return this.sex; }
            private set { }
        }
    }
}
