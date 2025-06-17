namespace ClassType
{
    public class Engine
    {
        public bool oil;            // can be accessed from anywhere
        private bool _crankshaft;   // can be accessed by the class
        protected int _pistons;     // can be accessed by child classes
        internal bool _camshaft;    // can be accessed within the current assembly
    }
}
