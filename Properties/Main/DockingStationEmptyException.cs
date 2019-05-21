using System;
namespace Boris_Bikes_Csharp
{
    public class DockingStationEmptyException : Exception
    {
        public DockingStationEmptyException(string message) : base(message)
        {
        }
    }
}
