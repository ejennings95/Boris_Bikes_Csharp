using NUnit.Framework;
using System;
namespace Boris_Bikes_Csharp.Test
{
    public class BikeTest
    {
        [Test, Description("Bike starts in working condition")]
        public void Condition()
        {
            Bike bike = new Bike();
            Assert.AreEqual("Working", bike.GetCondition());
        }

        [Test, Description("Bike can be set to broken")]
        public void BrokenCondition()
        {
            Bike bike = new Bike();
            bike.ConditionBroken();
            Assert.AreEqual("Broken", bike.GetCondition());
        }

        [Test, Description("Bike can be set to working ")]
        public void WorkingCondition()
        {
            Bike bike = new Bike();
            bike.ConditionBroken();
            Assert.AreEqual("Broken", bike.GetCondition());
            bike.ConditionWorking();
            Assert.AreEqual("Working", bike.GetCondition());
        }
    }
}
