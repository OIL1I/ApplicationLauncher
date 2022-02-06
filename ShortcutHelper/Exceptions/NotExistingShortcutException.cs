using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class NotExistingShortcutException : Exception
    {
        public NotExistingShortcutException()
        {
        }

        public NotExistingShortcutException(string message) : base(message)
        {
        }

        public NotExistingShortcutException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotExistingShortcutException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}