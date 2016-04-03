using System;

namespace Errors
{
    [Serializable()]
    public class PersonError : Exception
    {
        public PersonError() : base() { }
        public PersonError(string message) : base(message) { }
        public PersonError(string message, System.Exception inner) : base(message, inner) { }
        protected PersonError(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}