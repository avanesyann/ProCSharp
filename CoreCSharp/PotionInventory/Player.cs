namespace PotionInventory
{
    class Player
    {
        public string Name { get; set; }
        public int PotionCount { get; set; }
        public Potion? EquippedPotion { get; set; }

        public Player(string name, int potionCount, Potion? equippedPotion)
        {
            Name = name;
            EquippedPotion = equippedPotion;
            PotionCount = potionCount;
        }

        public string GetPotionInfo()
        {
            return EquippedPotion != null
                ? $"{Name} has {PotionCount} of {EquippedPotion?.Type} potions equipped."
                : $"{Name} has no potions equipped.";
        }

        public void UsePotion()
        {
            if (EquippedPotion != null && PotionCount > 0)
            {
                PotionCount--;
                Console.WriteLine($"{Name} used a {EquippedPotion?.Type} potion. Remaining: {PotionCount}");
            }
            else
            {
                Console.WriteLine($"{Name} has no potion to use!");
            }
        }
    }
}
