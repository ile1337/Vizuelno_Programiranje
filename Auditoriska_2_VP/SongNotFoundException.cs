using System;
using System.Runtime.Serialization;

namespace Auditoriska_2_VP
{
    [Serializable]
    internal class SongNotFoundException : Exception
    {
        public SongNotFoundException()
        {
        }

        public SongNotFoundException(string message) : base(message)
        {
        }

        public SongNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SongNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}