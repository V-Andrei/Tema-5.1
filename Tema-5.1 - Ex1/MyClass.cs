namespace Tema_5._1___Ex1
{
    class MyClass
    {

        private Teacher[] teachers;
        private Student[] students;
        private string textID;
        private string comment;

        public MyClass(Teacher[] teachers, Student[] students, string textID)
            : this(teachers, students, textID, null)
        { }
        public MyClass(Teacher[] teachers, Student[] students, string textID, string comment)
        {
            this.teachers = teachers;
            this.students = students;
            this.textID = textID;
            this.comment = comment;
        }


        Teacher[] Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }
        Student[] Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        string TextID
        {
            get { return this.textID; }
            set { this.textID = value; }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }
    }

}
