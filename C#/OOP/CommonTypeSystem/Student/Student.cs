namespace Student
{
    using System;
    using Enumarations;

    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public long SSN { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string EMail { get; set; }

        public string Course { get; set; }

        public Specialty Specialty { get; set; }

        public University Univesity { get; set; }

        public Faculty Faculty { get; set; }

        public override bool Equals(object obj)
        {
            Student comparedStudent = obj as Student;

            if (comparedStudent == null)
            {
                return false;
            }

            if (this.FirstName != comparedStudent.FirstName) return false;
            if (this.MiddleName != comparedStudent.MiddleName) return false;
            if (this.LastName != comparedStudent.LastName) return false;
            if (this.SSN != comparedStudent.SSN) return false;
            if (this.PermanentAddress != comparedStudent.PermanentAddress) return false;
            if (this.EMail != comparedStudent.EMail) return false;
            if (this.Course != comparedStudent.Course) return false;
            if (this.Specialty != comparedStudent.Specialty) return false;
            if (this.Specialty != comparedStudent.Specialty) return false;
            if (this.Univesity != comparedStudent.Univesity) return false;
            if (this.Faculty != comparedStudent.Faculty) return false;

            return true;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} from {2} University. Specialty: {3}", this.FirstName, this.LastName, this.Univesity, this.Specialty);
        }

        public override int GetHashCode()
        {
            return this.LastName.GetHashCode() ^ this.Specialty.GetHashCode() ^ this.Univesity.GetHashCode();
        }

        public static bool operator == (Student first, Student second)
        {
            return first.Equals(second);
        }

        public static bool operator != (Student first, Student second)
        {
            return !first.Equals(second);
        }

        public object Clone()
        {
            Student newStudent = new Student {
                                              FirstName = this.FirstName, MiddleName = this.MiddleName ,
                                              LastName = this.LastName,  SSN = this.SSN, Univesity = this.Univesity,
                                              PermanentAddress = this.PermanentAddress, EMail =this.EMail,
                                              MobilePhone = this.MobilePhone, Course = this.Course,
                                              Specialty = this.Specialty , Faculty = this.Faculty
                                             };
            return newStudent;
        }



        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) < 0)
            {
                return -1;
            }
            else if (this.FirstName.CompareTo(other.FirstName) > 0)
            {
                return 1;
            }
            else
            {
                if (this.SSN < other.SSN)
                {
                    return -1;
                }
                else if (this.SSN > other.SSN)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
