namespace MagicalZoo
{
    public abstract class MagicalCreature
    {
        public string Name { get; set; }
        public abstract void MakeSound();
    }

    public class Dragon : MagicalCreature
    {
        public bool CanBreatheFire { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Roarrr!");
        }
        public void BreatheFire()
        {
            Console.WriteLine("Woosh!");
        }
    }
}
