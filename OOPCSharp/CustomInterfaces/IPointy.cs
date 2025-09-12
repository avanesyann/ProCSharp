using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
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
