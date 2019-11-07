namespace Tema_5._1
{
    public class Student : Human
    {
        public Student (string firstName, string lastName) 
            : base (firstName, lastName)
        {

        }
        public int Grade { get; set; }
    }
}
