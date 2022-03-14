using System;
using System.Runtime.Serialization;

namespace Lab01a_NumbersGame
{
    [Serializable]
    internal class IndexOutOfRange : Exception
    {
        public IndexOutOfRange()
        {
        }

        public IndexOutOfRange(string message) : base(message)
        {
        }

        public IndexOutOfRange(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IndexOutOfRange(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}