using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Car   // base class, aka superclass, parent class
    {
        public readonly int MaxSpeed;
        private int _currSpeed;

        public Car(int max)
        {
            MaxSpeed = max;
        }
        public Car()
        {
            MaxSpeed = 55;
        }

        public int Speed
        {
            get { return _currSpeed; }
            set
            {
                _currSpeed = value;
                if (_currSpeed > MaxSpeed)
                {
                    _currSpeed = MaxSpeed;
                }
            }
        }
    }
    // sealed class, meaning that you can't derive from this class
    sealed class MiniVan : Car     // derived class, aka child class
    {
        public bool HasSlidingDoor { get; set; }
    }
}
