using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    // This class derives from System.Object and implements a single interface.
    // public class Pencil : IPointy { }

    // This class also derives from System.Object and implements a single interface.
    // public class SwitchBlade : Object, IPointy { }

    // This class derives from a custom base class and implements a single inetrface.
    //public class Fork : Utensil, IPointy { }

    // This struct implicity derives from System.ValueType and implements two interfaces.
    //public struct PitchFork : ICloneable, IPointy { }

    public interface IPointy
    {
        // Implicitly public and abstract.
        byte GetNumberOfPoints();

        // A read-write property in an interface would look like:
        // string PropName { get; set; }

        // a read-only property
        byte Points { get; }
    }
}
