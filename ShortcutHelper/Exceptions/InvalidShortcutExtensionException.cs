using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class InvalidShortcutExtensionException : Exception
    {

        public InvalidShortcutExtensionException()
        {
        }

        public InvalidShortcutExtensionException(string message) : base(message)
        {
        }  

        public InvalidShortcutExtensionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidShortcutExtensionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}