namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass
    {
        private List<Student> students;
        private List<Teacher> teachers;

        public SchoolClass(string name)
        {
            this.ClassIdentifier = name;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public string ClassIdentifier { get; set; }
        public string Comment { get; set; }


        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students =  value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }
    }
}
