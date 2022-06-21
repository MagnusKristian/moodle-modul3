using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    abstract class Person 
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string gender { get; set; }

        protected Person(int age, string name, string gender)
        {
            Age = age;
            Name = name;
            this.gender = gender;
        }

        public void Talk()
        {   
            Console.WriteLine("'Talk'");
        }
    }
}
