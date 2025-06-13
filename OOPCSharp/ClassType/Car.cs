namespace ClassType
{
    class Car
    {
        private string Name;
        private int Speed;

        public Car(string name) => Name = name;
        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
        public Car(string name, int speed, out bool inDanger)
        {
            Name = name;
            Speed = speed;

            if (speed >= 120)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }

        public void PrintState() => Console.WriteLine("{0} is going {1} KM/H.", Name, Speed);
        public void SpeedUp(int delta) => Speed += delta;
    }
}
