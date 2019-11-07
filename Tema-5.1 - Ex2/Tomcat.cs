namespace Tema_5._1___Ex2
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name)
            : base(age, name, Sex.male)
        { }

        public Sex GetGender
        {
            get { return this.sex; }
            private set { }
        }
    }
}
