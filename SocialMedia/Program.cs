using System;
using System.Collections.Generic;

namespace SocialMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Magnus",25);
            var person2 = new Person("Roger",24);
            var person3 = new Person( "Jonas", 29);
            var person4 = new Person( "Cecilie", 20);
            var person5 = new Person( "Thea", 23);

            var Everyone = new List<Person>(){ };
            Everyone.Add(person1);
            Everyone.Add(person2);
            Everyone.Add(person3);
            Everyone.Add(person4);
            Everyone.Add(person5);

            //People.Add(person2);
            //People.Add(person3);
            //People.Add(person4);
            //People.Add(person5);

            //gi roger et par venner: 
            person2.Friends.Add(person1);
            person2.Friends.Add(person3);

            person1.AddFriend(Everyone);
            var i = 1;
            foreach (var peeps in Everyone)
            {
                
                Console.WriteLine($"Name: {peeps.Name}. Age: {peeps.Age}. ID: {peeps.Id}.");
                Console.WriteLine($"{peeps.Name}'s friends: ");
                for (var j = 0; j < peeps.Friends.Count; j++)
                {
                    Console.WriteLine($"{peeps.Friends[j].Name}");
                }
                //foreach (var friend in peeps.Friends)
                //{i++;
                //    Console.WriteLine($"This persons friends: {peeps.Friends[0].Name}");
                //}

                Console.WriteLine($"-----------");
                //Console.WriteLine($"Friends: {peeps.Friends[i].Name}");
            }

            person1.PrintUserInfo();
        }
    }
}


/*
    Oppgave Social Media
    Oppgave - Social Media

        Lag applikasjon FriendFace. Det er tiltenkt at dette skal bli det nyeste kule sosiale mediet som tar verden med storm. 
        Her trenger en bruker en profilside med diverse info om seg (ta gjerne inspirasjon fra andre sosiale medier),

    Du må lage en metode som heter “AddFriend” og en metode “RemoveFriend”.

    Når programmet starter opp skal du lage en hovedbruker som er “innlogget”.
Du må også opprette flere forskjellige brukere som lever på det sosiale mediet.

        Lag et kommandbasert meny i konsollen der du kan:

    Legge til forskjellige brukere som venn (på den som er innlogget)
    Fjerne brukere som venn
    Printe ut en liste av alle man har lagt til som venn
    Velge en av vennene og printe ut profilinformasjonen deres.
*/