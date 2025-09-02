namespace CustomException
{
    public class CarIsDeadException : ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string cause, DateTime time) : this(cause, time, string.Empty)
        {

        }
        public CarIsDeadException(string cause, DateTime time, string message) : this(cause, time, message, null)
        {

        }
        public CarIsDeadException(string cause, DateTime time, string message, System.Exception inner) : base(message, inner)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        // you are not required to override the virtual Message property
        public CarIsDeadException(string message, string cause, DateTime time) : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}
