using SmartHome;

Home myHome = new Home();
SmartDevice smartBulb = new SmartBulb { Name = "Smart Bulb"};

myHome.AddDevice(smartBulb);
myHome.AddDevice("Thermostat");
myHome.AddDevice("Speaker").TogglePower();

smartBulb.TogglePower();

var thermostat = new SmartThermostat("Living Room Thermostat", 22.5);
myHome.AddDevice(thermostat);

thermostat.SetTemperature(18);
thermostat.TogglePower();

myHome.ShowStatus();