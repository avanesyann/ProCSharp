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
}
