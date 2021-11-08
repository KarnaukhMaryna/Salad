using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
    class Carrot:Vegetable
    {
        public Carrot()
        {
            Random rand = new Random();
            weight = rand.Next(76, 225);
            colour = "orange";
            calories = Calories(weight);
        }

        public Carrot(int weight)
        {
            this.weight = weight;
            colour = "orange";
            calories = Calories(weight);
        }

        public override double Calories(int weight)
        {
            return Math.Round(weight / 100.0 * 32.0, 2);
        }

        public override string ToString()
        {
            return string.Format("Carrot's weight is {0}, calories {1}, colour is {2}", arg0: weight, arg1: calories, arg2: colour);
        }
    }
}
