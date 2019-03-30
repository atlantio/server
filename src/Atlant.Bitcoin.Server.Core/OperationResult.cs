namespace Atlant.Bitcoin.Server.Core
{
    public class OperationResult
    {
        public bool IsSucceeded { get; }
        public string Message { get; }

        public OperationResult(bool isSucceeded, string message)
        {
            IsSucceeded = isSucceeded;
            Message = message;
        }
    }
}
