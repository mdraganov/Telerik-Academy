namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private List<People> allPeopleInSchool;
        private List<SchoolClass> classes;

        public School(string name)
        {
            this.Name = name;
            this.classes = new List<SchoolClass>();
            this.allPeopleInSchool = new List<People>();
        }

        public List<People> AllPeopleInSchool 
        {
            get
            {      
                foreach (var schoolClass in this.Classes)
                {
                    foreach (var teacher in schoolClass.Teachers)
                    {
                        allPeopleInSchool.Add(teacher);
                    }

                    foreach (var student in schoolClass.Students)
                    {
                        allPeopleInSchool.Add(student);
                    }
                }

                return this.allPeopleInSchool;
            }
        }

        public List<SchoolClass> Classes 
        {
            get
            {                
                return this.classes;
            }
            set
            {                
                this.classes = value;
            }
        }

        public string Name { get; set; }
    }
}
