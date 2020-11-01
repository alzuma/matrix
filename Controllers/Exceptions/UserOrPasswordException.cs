using System;
using System.Runtime.Serialization;

namespace Matrix.Controllers.Exceptions
{
    public class UserOrPasswordException : Exception
    {
        public UserOrPasswordException()
        {
        }

        protected UserOrPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public UserOrPasswordException(string? message) : base(message)
        {
        }

        public UserOrPasswordException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}