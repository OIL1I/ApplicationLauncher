using System;
using System.Runtime.Serialization;

namespace ApplicationLauncher.Exceptions
{
    [Serializable]
    public class SavePathNotFoundException : Exception
    {
        public SavePathNotFoundException() { }

        public SavePathNotFoundException(string directoryPath) : base(String.Format("One Savefilepath: \"{0}\", was not found!", directoryPath)) { }

        public SavePathNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SavePathNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
