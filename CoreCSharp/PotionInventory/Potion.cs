namespace PotionInventory
{
    enum PotionType { Healing, Mana, Stamina, Rehabilitating }
    struct Potion
    {
        public PotionType Type { get; set; }
        public int RestoreAmount { get; set; }

        public Potion(PotionType type, int restoreAmount)
        {
            Type = type;
            RestoreAmount = restoreAmount;
        }
    }
}
