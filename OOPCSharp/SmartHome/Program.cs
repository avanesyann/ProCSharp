using SmartHome;

Home myHome = new Home();
SmartDevice smartBulb = new SmartDevice { Name = "Smart Bulb"};

myHome.AddDevice(smartBulb);
myHome.AddDevice("Thermostat");
myHome.AddDevice("Speaker").TogglePower();

smartBulb.TogglePower();
myHome.ShowStatus();