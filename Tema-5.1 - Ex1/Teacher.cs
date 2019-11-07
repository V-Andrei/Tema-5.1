using System;
using System.Collections.Generic;

namespace Tema_5._1___Ex1
{
    class Teacher : Person
    {

        private List<Discipline> setDisciplines { get; set; }

        public Teacher(string name, List<Discipline> setDisciplines)
            : this(name, setDisciplines, null)
        { }

        public Teacher(string name, List<Discipline> setDisciplines, string comment)
            : base(name, comment)
        {
            this.setDisciplines = setDisciplines;
        }

        public List<Discipline> SetDisciplines
        {
            get { return this.setDisciplines; }
            set
            {
                if (setDisciplines.Count < 1)
                {
                    throw new ArgumentException("The teacher should have at least one discipline!");
                }
            }
        }
    }
}
