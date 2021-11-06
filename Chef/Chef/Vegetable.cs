using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
   
      class Vegetable
      {
        protected int weight;
        public double calories;
        protected string colour;

        public virtual double Calories(int weight)
        {
            return Math.Round(weight/100 *calories, 2);
        }

        public override string ToString()
        {
            return string.Format($"{weight} {calories} {colour}");
        }

    }
}
