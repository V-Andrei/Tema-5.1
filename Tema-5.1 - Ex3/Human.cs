namespace Tema_5._1
{
    public class Human
    {
        public Human (string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string GetFirstName()
        {
            return this.FirstName;
        }

        public string GetLastName()
        {
            return this.LastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
