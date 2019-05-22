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

        [Test, Description("Can release a bike from docking station")]
        public void CanReleaseBike()
        {
            var bike = Mock.Of<Bike>();
            DockingStation dockingstation = new DockingStation();
            dockingstation.DockBike(bike);
            Assert.AreEqual(1, dockingstation.GetDockedBikes().Count);
            dockingstation.ReleaseBike();
            Assert.AreEqual(0, dockingstation.GetDockedBikes().Count);
        }

        [Test, Description("Docking station capacity is defaulted to 20")]
        public void DockCapacity20Bikes()
        {
            DockingStation dockingstation = new DockingStation();
            Assert.AreEqual(20, dockingstation.GetCapacity());
        }

        [Test, Description("Cannot dock bike if docking station is full")]
        [ExpectedException(typeof(DockingStationFullException))]
        public void FullDockingStation()
        {
            var bike = Mock.Of<Bike>();
            var bike2 = Mock.Of<Bike>();
            DockingStation dockingstation = new DockingStation(1);
            dockingstation.DockBike(bike);
            dockingstation.DockBike(bike2);
        }

        [Test, Description("Cannot relesase bike if docking station is empty - none docked ever")]
        [ExpectedException(typeof(DockingStationEmptyException))]
        public void EmptyDockingStation()
        {
            DockingStation dockingstation = new DockingStation();
            dockingstation.ReleaseBike();
        }

        [Test, Description("Cannot relesase bike if docking station is empty")]
        [ExpectedException(typeof(DockingStationEmptyException))]
        public void EmptyDockingStation2()
        {
            var bike = Mock.Of<Bike>();
            DockingStation dockingstation = new DockingStation();
            dockingstation.DockBike(bike);
            dockingstation.ReleaseBike();
            dockingstation.ReleaseBike();
        }

        [Test, Description("Cannot relesase bike if the bike is broken")]
        [ExpectedException(typeof(BikeIsNotWorkingException))]
        public void BrokenBike()
        {
            Mock<Bike> bike = new Mock<Bike>();
            bike.CallBase = true;
            bike.Setup(x => x.GetCondition()).Returns("Broken");
            DockingStation dockingstation = new DockingStation();
            dockingstation.DockBike(bike);
            dockingstation.ReleaseBike();
        }
    }
}
