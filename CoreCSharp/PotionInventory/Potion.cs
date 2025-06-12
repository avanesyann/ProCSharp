namespace PotionInventory
{
    enum PotionType { Healing, Mana, Stamina, Rehabilitating }
    [Flags]
    enum PotionEffect
    {
        None = 0,
        Heal = 1,
        Boost = 2,
        Cure = 4,
        Shield = 8
    }
    struct Potion
    {
        public PotionType Type { get; set; }
        public PotionEffect Effect { get; init; }
        public int RestoreAmount { get; set; }

        public Potion(PotionType type, int restoreAmount)
        {
            Type = type;
            RestoreAmount = restoreAmount;
        }
    }
}
