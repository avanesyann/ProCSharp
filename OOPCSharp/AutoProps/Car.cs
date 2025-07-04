﻿namespace AutoProps
{
    class Car
    {
        // Automatic properties! No need to define backing fields.
        public string? PetName { get; set; }
        public int Speed { get; set; }
        public string? Color { get; set; }

        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Car Speed: {0}", Speed);
            Console.WriteLine("Car Color: {0}", Color);
        }
    }
}
