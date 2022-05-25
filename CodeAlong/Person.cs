using System;

namespace CodeAlong
{
    public class Person
    {
        public string Name { get; private set; }
        public string Age { get; private set; }

        public bool IsTeacher { get; private set; }

        public Person(string name, string age, bool isTeacher )
        {
            Name = name;
            Age = age;
            IsTeacher = isTeacher;
        }

        public static void PrintPerson(Person person)
        {
            Console.WriteLine($"Navn: {person.Name}, Alder: {person.Age}, Er lærer: {person.IsTeacher}");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Navn: {Name}, Alder: {Age}, Er lærer: {IsTeacher}");
        }

        public void SpeakToAnotherPerson(Person person)
        {
            System.Console.WriteLine($"{Name} greeted {person.Name} politely.");
        }
    }
}