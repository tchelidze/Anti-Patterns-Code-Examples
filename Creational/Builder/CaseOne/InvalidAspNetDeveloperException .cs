using System;

namespace Builder.CaseOne
{
    public class InvalidAspNetDeveloperException : Exception
    {
        public InvalidAspNetDeveloperException(string why) : base(why)
        {

        }
    }
}