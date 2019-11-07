namespace Tema_5._1___Ex1
{
    public class Person
    {

        private string name;
        private string comment;

        public Person(string name)
            : this(name, null)
        {

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Person(string name, string comment)
        {
            this.name = name;
            this.comment = comment;
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }
    }
}
