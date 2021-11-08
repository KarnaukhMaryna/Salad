using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
    class Tomatoe : Vegetable
    {
        
        public Tomatoe()
        {
            Random rand = new Random();
            weight = rand.Next(100, 251);
            colour = "red";
            calories = Calories(weight);
        }

        public Tomatoe(int weight)
        {
            this.weight = weight;
            colour = "red";
            calories = Calories(weight);
        }

        public override double Calories(int weight)
        {
            return Math.Round(weight/100.0*18.0, 2);
        }

        public override string ToString()
        {
            return string.Format("Tomatoe's weight is {0}, calories {1}, colour is {2}", arg0: weight, arg1: calories, arg2: colour);
        }
    }
}
