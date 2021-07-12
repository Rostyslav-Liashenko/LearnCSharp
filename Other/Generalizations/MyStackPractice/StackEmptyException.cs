using System;

namespace LearnGeneralization
{
    public class StackEmptyException : Exception
    {
        public StackEmptyException() : base()
        {}

        public StackEmptyException(string str) : base(str)
        {}
        protected StackEmptyException(
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
