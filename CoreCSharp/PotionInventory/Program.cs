namespace PotionInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Potion? healing = new Potion("Healing", 20);
            Potion? megaHeal = new Potion("Mega Healing", 50);
            Potion? rehab = new Potion("Rehabilitating", 100);

            List<Player?> players = new List<Player?>();
            players.Add(new Player("Mario", 2, healing));
            players.Add(new Player("Terminator", 12, null));
            players.Add(new Player("John Wick", 4, rehab));

            foreach (Player? player in players)
            {
                Console.WriteLine($"{player?.Name} has {player?.PotionCount} of {player?.EquippedPotion?.Name ?? "no"} potions left.");
            }
        }
    }
}
