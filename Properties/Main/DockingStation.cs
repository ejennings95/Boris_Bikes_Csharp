﻿using System;
using System.Collections.Generic;

namespace Boris_Bikes_Csharp
{
    public class DockingStation
    {
        List<Bike> dockedBikes = new List<Bike>();

        public DockingStation()
        {   
        }

        public List<Bike> GetDockedBikes ()
        {
            return dockedBikes;
        }
    }
}