using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Chef
{
    class SaladCollection : IEnumerable
    {
        private IList SaladArray { get;}

        public SaladCollection()
        {
            SaladArray = new ArrayList();
        }

        public SaladCollection(IEnumerable saladCollection)
        {
            SaladArray = new ArrayList();
            foreach (Vegetable item in saladCollection)
            {
                SaladArray.Add(item);
            }
        }

        public int Count 
        {
            get 
            { 
                return SaladArray.Count; 
            } 
        }

        public IEnumerator GetEnumerator() 
        {
            for (int index = 0; index < Count; index++) 
            { 
                yield return SaladArray[index]; 
            } 
        }
        
        public int Add(Vegetable vegetable) 
        { 
            return SaladArray.Add(vegetable);
        }

        public void RemoveAt(int index) 
        {
            SaladArray.RemoveAt(index); 
        }

        public void Remove(Vegetable vegetable) 
        {
            SaladArray.Remove(vegetable); 
        }

        public double CaloriesInSalad()
        {
            double saladCalories = 0;
            foreach( Vegetable l in SaladArray)
            {
                saladCalories += l.calories;
            }
            return saladCalories;
        }

        public static SaladCollection WeightFilter(SaladCollection Vegetables, double weight)
        {
            var NewCollection = from Vegetable vegetable in Vegetables
                                where vegetable.weight > weight
                                orderby vegetable.weight descending
                                select vegetable;
            return new SaladCollection(NewCollection);
        }

        public static SaladCollection ColourFilter(SaladCollection Vegetables, string colour)
        {
            var NewCollection = from Vegetable vegetable in Vegetables
                           where vegetable.colour == colour
                           select vegetable;
            return new SaladCollection(NewCollection);
        }

        public static SaladCollection CaloriesFilter(SaladCollection Vegetables, double calories)
        {
            var NewCollection = from Vegetable vegetable in Vegetables
                                where vegetable.calories > calories
                                orderby vegetable.calories descending
                                select vegetable;
            return new SaladCollection(NewCollection);
        }

        public static void OutputOnDisplay(SaladCollection SaladArray)
        {
            foreach (var vegetable in SaladArray)
            {
                Console.WriteLine(vegetable);
            }
        }

    }
}
