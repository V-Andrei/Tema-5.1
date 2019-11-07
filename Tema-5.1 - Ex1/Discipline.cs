namespace Tema_5._1___Ex1
{
    class Discipline
    {
        private string classDiscipline;
        private int countLectures;
        private int countExercises;

        public Discipline(string discipline, int countLectures, int countExercises)
        {
            this.classDiscipline = discipline;
            this.countLectures = countLectures;
            this.countExercises = countExercises;
        }

        public string ClassDiscipline
        {
            get { return this.classDiscipline; }
            set { this.classDiscipline = value; }
 
        }

        public int CountLectures
        {
            get { return this.countLectures; }
            set { this.countLectures = value; }
        }

        public int CountExercises
        {
            get { return this.countExercises; }
            set { this.countExercises = value; }
        }
    }
}
