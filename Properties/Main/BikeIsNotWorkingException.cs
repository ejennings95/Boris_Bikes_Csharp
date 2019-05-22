using System;
namespace Boris_Bikes_Csharp
{
    public class BikeIsNotWorkingException : Exception
    {
        public BikeIsNotWorkingException(string message) : base(message)
        {
        }
    }
}
