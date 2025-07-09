using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Animal
    {
        public string? Name { get; init; }
        public string? Species { get; init; }
        public int Age { get; init; }
        public bool IsEndangered { get; init; }

        public Animal() { }
        public Animal(string? name, string? species, int age, bool isEndangered)
        {
            Name = name;
            Species = species;
            Age = age;
            IsEndangered = isEndangered;
        }
    }
}
