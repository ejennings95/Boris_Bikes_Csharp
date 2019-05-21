using System;
using System.Collections.Generic;

namespace Boris_Bikes_Csharp
{
    public class DockingStation
    {
        List<Bike> dockedBikes = new List<Bike>();
        public int CapacityOfDockingStation = 20;

        public DockingStation()
        {   
        }

        public DockingStation(int capacity)
        {
            CapacityOfDockingStation = capacity;
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
            if (dockedBikes.Count >= CapacityOfDockingStation)
            {
                throw new DockingStationFullException("Docking station is full");
            } else
            {
                dockedBikes.Add(bike);
            }
        }

        public void ReleaseBike()
        {
            dockedBikes.RemoveAt(dockedBikes.Count - 1);
        }
    }
}
