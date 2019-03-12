using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    class SmallCar : Car
    {
        public SmallCar(int yearOfProduction) : base(yearOfProduction)
        {
        }

        public override string StartEngine()
        {
            return "Small car starts the engine.";
        }

        public override string StopEngine()
        {
            return "Small car stops the engine.";
        }
    }
}
