using System.Runtime.Serialization;

namespace TestAssignmentMindbox.Exceptions
{
    public class InvalidTrangleSidesException : Exception
    {
        public InvalidTrangleSidesException()
        {
        }

        public InvalidTrangleSidesException(string? message) : base(message)
        {
        }

        public InvalidTrangleSidesException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidTrangleSidesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
