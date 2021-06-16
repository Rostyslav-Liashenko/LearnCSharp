using System;

namespace LearnException
{
    public class RangeArrayException : Exception
    {
        public RangeArrayException() : base()
        {}

        public RangeArrayException(string str) : base(str)
        {}
        
        public RangeArrayException(string str, Exception inner) : base(str, inner)
        {}

        protected RangeArrayException(
            System.Runtime.Serialization.SerializationInfo si,
            System.Runtime.Serialization.StreamingContext sc
        ) : base(si, sc) 
        {}
        
        public override string ToString()
        {
            return Message;
        }

    }
}
