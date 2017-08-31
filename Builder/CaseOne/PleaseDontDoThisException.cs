using System;

namespace Builder.CaseOne
{
    public class PleaseDontDoThisException : Exception
    {
        public PleaseDontDoThisException(string whatHappened) : base(whatHappened)
        { }
    }
}