namespace PotionInventory
{
    class Potion
    {
        public string Name { get; set; }
        public int RestoreAmount { get; set; }

        public Potion(string name, int restoreAmount)
        {
            Name = name;
            RestoreAmount = restoreAmount;
        }
    }
}
