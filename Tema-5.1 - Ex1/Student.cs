namespace Tema_5._1___Ex1
{
    public class Student : Person
    {

        private int classNumber;

        public Student(string name, int classNumber)
            : this(name, classNumber, null)
        { }

        public Student(string name, int classNumber, string comment)
            : base(name, comment)
        {
            this.classNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value; }
        }
    }
}
