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
            if (dockedBikes.Count == 0)
            {
                throw new DockingStationEmptyException("Docking station is empty");
            }
            if (dockedBikes[dockedBikes.Count - 1].GetCondition() == "Broken")
            {
                throw new BikeIsNotWorkingException("This bike is not working");
            }
            dockedBikes.RemoveAt(dockedBikes.Count - 1);
        }
    }
}
