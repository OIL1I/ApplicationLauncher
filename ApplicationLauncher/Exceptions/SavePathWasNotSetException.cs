using System;
using System.Runtime.Serialization;

namespace ApplicationLauncher.Exceptions
{
    [Serializable]
    internal class SavePathWasNotSetException : Exception
    {
        public SavePathWasNotSetException(): base("One Savefilepath was not set!")
        {
        }

        public SavePathWasNotSetException(string message) : base(message)
        {
        }

        public SavePathWasNotSetException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SavePathWasNotSetException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}