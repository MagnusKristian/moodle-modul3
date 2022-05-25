using System;

namespace CodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var meg = new Person("Magnus","25",false);
            var Bjørnar = new Person("Bjørnar","31",true);
            //Console.WriteLine($"Navn: {meg.Name}, Alder: {meg.Age}, Er lærer: {meg.IsTeacher}");
            Person.PrintPerson(meg);
            
            meg.PrintInfo();


            Bjørnar.SpeakToAnotherPerson(meg);
        }
    }
}
