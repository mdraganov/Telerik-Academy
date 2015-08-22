namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People
    {
        private List<Discipline> disciplines;

        public Teacher()
        {
            this.disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get 
            {
                return this.disciplines; 
            }
            set 
            {
                this.disciplines = value; 
            }
        }
    }
}
