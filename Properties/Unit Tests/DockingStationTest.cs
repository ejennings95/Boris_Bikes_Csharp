using Boris_Bikes_Csharp;
using NUnit.Framework;
using System;
using Moq;
namespace Boris_Bikes_Csharp.Test
{
    public class DockingStationTest
    {
        [Test, Description("Docking station docked bikes should start empty")]
        public void EmptyDockedBikes()
        {
            DockingStation dockingstation = new DockingStation();
            Console.WriteLine(dockingstation.GetDockedBikes());
            Assert.AreEqual(0, dockingstation.GetDockedBikes().Count);
        }

        [Test, Description("Can dock a bike at a docking station")]
        public void CanDockBike()
        {
            var bike = Mock.Of<Bike>();
            DockingStation dockingstation = new DockingStation();
            dockingstation.DockBike(bike);
            Assert.AreEqual(1, dockingstation.GetDockedBikes().Count);
        }
    }
}
