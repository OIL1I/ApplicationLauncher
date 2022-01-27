using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    public class NotExistingLinkDirectoryException : Exception
    {
        public NotExistingLinkDirectoryException()
        {
        }

        public NotExistingLinkDirectoryException(string message) : base(message)
        {
        }

        public NotExistingLinkDirectoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotExistingLinkDirectoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}