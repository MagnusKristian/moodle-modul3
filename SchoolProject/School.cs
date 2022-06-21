using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class School 
    {
        public List<ClassRoom> ClassRooms { get; set; }
        public School()
        {
            
            var classroom5 = new ClassRoom();

            var person44 = new Student(20,"Roger","mann");
            var person432 = new Student(22, "erik", "mann");

            classroom5.Students.Add(person44);
            classroom5.Students.Add(person432);





            //var classroom2 = new ClassRoom();
            //var classroom3 = new ClassRoom();

        }

        public void lagNoe()
        {
            var classroom5 = new ClassRoom();
            var person44 = new Student(20, "Roger", "mann");
            var person432 = new Student(22, "erik", "mann");

            classroom5.Students.Add(person44);
            classroom5.Students.Add(person432);
        }
    }
}
