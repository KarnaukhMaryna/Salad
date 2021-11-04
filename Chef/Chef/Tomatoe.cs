using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
    class Tomatoe : Vegetable
    {
        private int weight;
        public double calories { get; }
        private string colour;

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
            return weight/100.0*18.0;
        }
    }
}
