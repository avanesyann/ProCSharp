namespace PotionInventory
{
    class Player
    {
        public string Name { get; set; }
        public int PotionCount { get; set; } = 0;
        public Potion? EquippedPotion { get; set; }

        public Player(string name, int potionCount, Potion? equippedPotion)
        {
            Name = name;
            EquippedPotion = equippedPotion;
            if (equippedPotion != null)
                PotionCount = potionCount;
        }
    }
}
