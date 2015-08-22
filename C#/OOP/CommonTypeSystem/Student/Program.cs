using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student();

            Type type = newStudent.GetType();

            foreach (var item in type.GetProperties())
            {
                Console.WriteLine(item);
            }
        }
    }
}
