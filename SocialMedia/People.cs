﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;

namespace SocialMedia
{
    public class Person
    {
        public int Id { get; private set; } = 1;
        public string Name { get; private set; }
        public int Age { get; private set; }

        public List<Person> Friends { get; private set; }
        public Person(string _name, int _age)
        {
            Name = _name;
            Age = _age;
            Friends = new List<Person>();
            Id++;
            //UpIdCount();
        }

        private void UpIdCount()
        {
            Id++;
        }

        public void AddFriend(List<Person> everyone)
        {

            Friends.Add(everyone[1]);
            Console.WriteLine($"{everyone[1].Name} was added to {Name}'s friendList.");
            Friends.Add(everyone[2]);
            Console.WriteLine($"{everyone[2].Name} was added to {Name}'s friendList.");
            Friends.Add(everyone[3]);
            Console.WriteLine($"{everyone[3].Name} was added to {Name}'s friendList.");
        }

        public void RemoveFriend()
        {

        }

        public void PrintUserInfo()
        {
            Console.WriteLine($" ********************");
            Console.WriteLine($" *{"FRIENDFACE".PadLeft(14).PadRight(18)}*");
            Console.WriteLine($" *{"NAME: ".PadLeft(9,' ')}{Name.PadRight(9)}*");
            Console.WriteLine($" *                  *");
            Console.WriteLine($" *{"AGE: ".PadLeft(9)}{Age}{"".PadRight(7)}*");
            Console.WriteLine($" *                  *");
            Console.WriteLine($" *{"ID: ".PadLeft(9)}{Id}{"*".PadLeft(9)}");
            Console.WriteLine($" *                  *");
            Console.WriteLine($" *                  *");
            Console.WriteLine($" ********************");

        }
    }
}