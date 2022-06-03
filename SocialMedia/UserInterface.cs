using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class UserInterface
    {
        public static void Interface()
        {
            Console.WriteLine("Welcome to FriendFace! ");
            Console.WriteLine("Choose '1' to show your friends ");
            Console.WriteLine("Choose '2' to add a friend ");
            Console.WriteLine("Choose '3' to remove a friend ");
            Console.WriteLine("Choose '4' to xxx ");
        }

        public static void InterfaceInput(List<Person> Everyone,Person person)
        {
            int UserInput = Convert.ToInt32(Console.ReadLine());
            if (UserInput == 1)
            {
                person.ShowFriends();
            }
            if (UserInput == 2)
            {
                Console.WriteLine("Type in the id of the person you want to add: ");
                string FriendUserInput = Console.ReadLine();
                person.AddFriend(Everyone ,FriendUserInput);
            }
            if (UserInput == 3)
            {

            }
        }
    }
}
