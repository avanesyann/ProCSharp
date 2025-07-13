namespace SmartHome
{
    class Home
    {
        private List<SmartDevice> _devices = new List<SmartDevice>();

        public void AddDevice(SmartDevice device)
        {
            _devices.Add(device);
        }
        public SmartDevice AddDevice(string name)
        {
            var device = new SmartDevice(name);
            _devices.Add(device);

            return device;
        }
        public void ShowStatus()
        {
            foreach (SmartDevice device in _devices)
            {
                Console.WriteLine($"{device.Name} is {(device.IsOn ? "On" : "Off")}");
            }
        }
        public void TurnAllOff()
        {
            foreach (SmartDevice device in _devices)
            {
                device.IsOn = false;
            }
        }
    }
}
