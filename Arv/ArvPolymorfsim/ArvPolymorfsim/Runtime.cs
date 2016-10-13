using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPolymorfsim
{
    class Runtime
    {

        public void Start()
        {
            Student myStudent = new Student
            {
                Name ="Råger",
                Age = 17,
                City = "Stockholm",
                Class = "SUN16"


            };
            Teacher myTeacher = new Teacher
            {
                Name = "John",
                Age = 53,
                City = "Stockholm",
                Subject = "Programmering"

            };
            Console.WriteLine(myStudent.Introduction());
            Console.WriteLine(myTeacher.Introduction());
        }
    }
}
