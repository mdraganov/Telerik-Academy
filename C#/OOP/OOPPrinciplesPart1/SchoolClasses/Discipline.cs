namespace SchoolClasses
{
    using System;

    public class Discipline
    {
        public Discipline()
        {

        }

        public Discipline(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExercises { get; set; }

        public string Comment { get; set; }
    }
}