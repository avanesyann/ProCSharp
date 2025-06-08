namespace PotionInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Potion healing = new Potion("Healing", 20);
            Potion megaHeal = new Potion("Mega Healing", 50);
            Potion rehab = new Potion("Rehabilitate", 100);

            List<Player> players = new List<Player>();
            players.Add(new Player("Mario", 2, healing));
            players.Add(new Player("Terminator", 12, null));

            foreach (Player player in players)
            {
                Console.WriteLine($"{player.Name} has {player.PotionCount} potions left.");
            }
        }
    }
}
