using System;
using System.Collections.Generic;

namespace Boris_Bikes_Csharp
{
    public class DockingStation
    {
        List<Bike> dockedBikes = new List<Bike>();
        public const int CapacityOfDockingStation = 20;

        public DockingStation()
        {   
        }

        public List<Bike> GetDockedBikes ()
        {
            return dockedBikes;
        }

        public int GetCapacity()
        {
            return CapacityOfDockingStation;
        }

        public void DockBike (Bike bike)
        {
            dockedBikes.Add(bike);
        }

        public void ReleaseBike()
        {
            dockedBikes.RemoveAt(dockedBikes.Count - 1);
        }
    }
}
