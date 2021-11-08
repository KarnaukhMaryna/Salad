using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
   
   class Vegetable
   {
        public int weight;
        public double calories;
        public string colour;

        public virtual double Calories(int weight)
        {
            return Math.Round(weight/100 *calories, 2);
        }

        
    }
}
