using System;
namespace Boris_Bikes_Csharp
{
    public class DockingStationFullException : Exception
    {
        public DockingStationFullException(string message) : base(message)
        {
        }
    }
}
