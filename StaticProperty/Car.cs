using System;
using System.Collections.Generic;
using System.Text;

namespace StaticProperty
{
    class Car
    {
        private string name;
        private string engine;
        public static int numberOfCars;
        public Car(string name, string engine)
        {
            this.name = name;
            this.engine = engine;
            numberOfCars++;
        }
        public override string ToString()
        {
            return "Name=" + name + ", Engine=" + engine;
        }
    }
}
