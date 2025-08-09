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

    public class Phoenix : MagicalCreature
    {
        public bool CanRevive { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Fweeeooo... trreeeiiil...");
        }
        public void Revive()
        {
            Console.WriteLine("I feel like I was just born again!");
        }
    }

    public class Unicorn : MagicalCreature
    {
        public bool CanHeal { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Whiiiiii-nee-ee-ee-ee… tinkle-tinkle… shhhh-oommm… shiii-iiiing!");
        }

        public void Heal()
        {
            Console.WriteLine("Damn, that was good.");
        }
    }
}
