namespace MagicalZoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<MagicalCreature> magicalCreatures = new List<MagicalCreature>();
            magicalCreatures.Add(new Dragon());
            magicalCreatures.Add(new Phoenix());
            magicalCreatures.Add(new Unicorn());

            foreach (MagicalCreature magicalCreature in magicalCreatures)
            {
                magicalCreature.MakeSound();

                if (magicalCreature is Dragon dragon)
                {
                    dragon.BreatheFire();
                }
                else if (magicalCreature is Phoenix phoenix)
                {
                    phoenix.Revive();
                }
                else if (magicalCreature is Unicorn)
                {
                    ((Unicorn)magicalCreature).Heal();
                }
                Console.WriteLine();
            }
        }
    }
}
