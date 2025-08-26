namespace CustomException
{
    public class CarIsDeadException : ApplicationException
    {
        private string _messageDetails = string.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause, DateTime time)
        {
            _messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        public override string Message => $"Car Error Message: {_messageDetails}";
    }
}
