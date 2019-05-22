using System;
namespace Boris_Bikes_Csharp
{
    public class Bike
    {
        string condition = "Working";

        public Bike()
        {
        }

        public virtual string GetCondition()
        {
            return condition;
        }

        public void ConditionBroken()
        {
            condition = "Broken";
        }

        public void ConditionWorking()
        {
            condition = "Working";
        }
    }
}
