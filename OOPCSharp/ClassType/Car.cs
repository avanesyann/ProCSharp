namespace ClassType
{
    class Car
    {
        private string _name;
        private int _speed;

        public Car(string name) => _name = name;
        public Car(string name, int speed)
        {
            _name = name;
            _speed = speed;
        }
        public Car(string name, int speed, out bool inDanger)
        {
            _name = name;
            _speed = speed;

            if (speed >= 120)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }

        public void PrintState() => Console.WriteLine("{0} is going {1} KM/H.", _name, _speed);
        public void SpeedUp(int delta) => _speed += delta;
    }
}
