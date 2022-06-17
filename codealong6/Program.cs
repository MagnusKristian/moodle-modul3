namespace codealong6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player();
            var player2 = new Player();

            player2.Inventory.Add(new Potions("mana"));
            player2.Inventory.Add( new Weapon("sword"));
            player2.Inventory.Add(new Accessory("chainmail"));

            foreach (var VARIABLE in player2.Inventory)
            {
                Console.WriteLine(VARIABLE.Name);
            }

        }
    }
}