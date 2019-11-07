namespace Tema_5._1___Ex1
{
    class School
    {

        private Student[] classStudents;


        public School(Student[] classStudents)
        {
            this.classStudents = classStudents;
        }

        Student[] ClassStudents
        {
            get { return this.classStudents; }
            set  {  this.classStudents = value; }
        }
    }
}
