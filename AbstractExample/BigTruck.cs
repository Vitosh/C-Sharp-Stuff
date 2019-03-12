using System;

namespace AbstractExample
{
    class BigTruck : Car
    {
        public BigTruck(int yearOfProduction) : base(yearOfProduction)
        {
        }

        public override string StartEngine()
        {
            return "Big truck starts the engine.";
        }

        public override string StopEngine()
        {
            return "Big truck stops the engine.";
        }
    }
}
