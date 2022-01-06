using System;
using System.Runtime.Serialization;

namespace ApplicationLauncher.Exceptions
{
    [Serializable]
    internal class ChangedSavePathException : Exception
    {
        public ChangedSavePathException() : base("Savepath was changed, this will result in the loss of all existing savefiles.")
        {
        }

        public ChangedSavePathException(string message) : base(message)
        {
        }

        public ChangedSavePathException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ChangedSavePathException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}