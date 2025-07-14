namespace SmartHome
{
    class SmartDevice
    {
        public string Name { get; init; }
        public bool IsOn { get; set; }

        public void TogglePower() => IsOn = !IsOn;

        public SmartDevice() { }
        public SmartDevice(string name) => Name = name;
    }

    class SmartBulb : SmartDevice
    {
        public int Brightness { get; set; }
        public string Color { get; set; }
    }

    class SmartThermostat : SmartDevice
    {
        public double Temperature { get; set; }

        public SmartThermostat(string name, double initialTemp)
        {
            Name = name;
            Temperature = initialTemp;
        }

        public void SetTemperature(double newTemp)
        {
            Temperature = newTemp;
            Console.WriteLine($"{Name} temperature set to {Temperature}°C");
        }
    }
}
