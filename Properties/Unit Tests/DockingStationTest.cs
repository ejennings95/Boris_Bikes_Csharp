using Boris_Bikes_Csharp;
using NUnit.Framework;
using System;
namespace Boris_Bikes_Csharp.Test
{
    public class DockingStationTest
    {
        [Test, Description("Docking station docked bikes should start empty")]
        public void TestCase()
        {
            DockingStation dockingstation = new DockingStation();
            Console.WriteLine(dockingstation.GetDockedBikes());
            Assert.AreEqual(0, dockingstation.GetDockedBikes().Count);
        }
    }
}
