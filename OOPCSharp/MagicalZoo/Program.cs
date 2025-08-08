namespace MagicalZoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            MagicalCreature creature = new Dragon();
            creature.MakeSound();

            if (creature is Dragon)
            {
                ((Dragon)creature).BreatheFire();
            }
        }
    }
}
