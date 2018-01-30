using System;

namespace Gelf
{
    public class GelfMessageTooBigException : Exception
    {
        public GelfMessageTooBigException()
        {
        }

        public GelfMessageTooBigException(string message)
            : base(message)
        {
        }

        public GelfMessageTooBigException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
