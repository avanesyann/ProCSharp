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
                // PrintCreatureInfo(magicalCreature);

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
        public static void PrintCreatureInfo(MagicalCreature creature)
        {
            switch (creature)
            {
                case Dragon d:
                    Console.WriteLine($"Creature: Dragon - Name: {d.Name}");
                    d.MakeSound();
                    d.BreatheFire();
                    break;
                case Phoenix p:
                    Console.WriteLine($"Creature: Phoenix - Name: {p.Name}");
                    p.MakeSound();
                    p.Revive();
                    break;
                case Unicorn u:
                    Console.WriteLine($"Creature: Dragon - Name: {u.Name}");
                    u.MakeSound();
                    u.Heal();
                    break;
                case null:
                    Console.WriteLine("No creature provided.");
                    break;
                default:
                    Console.WriteLine($"Unknown creature type: {creature.GetType().Name}");
                    break;
            }
        }
    }
}
