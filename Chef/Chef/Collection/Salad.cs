using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Chef
{
    class SaladCollection : IEnumerable
    {
        private IList List { get; }

        public SaladCollection()
        {
            List = new ArrayList();
        }

        public int Count 
        {
            get 
            { 
                return List.Count; 
            } 
        }

        public IEnumerator GetEnumerator() 
        {
            for (int index = 0; index < Count; index++) 
            { 
                yield return List[index]; 
            } 
        }
        
        public int Add(Vegetable vegetable) 
        { 
            return List.Add(vegetable);
        }

        public void RemoveAt(int index) 
        { 
            List.RemoveAt(index); 
        }

        public void Remove(Vegetable vegetable) 
        { 
            List.Remove(vegetable); 
        }

        public void CaloriesInSalad()
        {
            double Sum = 0;
            foreach( Vegetable l in List)
            {
                Sum += l.calories;
            }
            Console.WriteLine("{0} calories in salad", Math.Round(Sum, 2));
        }

        public static SaladCollection WeightFilter(SaladCollection Vegetables, double weight)
        {
            var NewCollection = from Vegetable vegetable in Vegetables
                                where  vegetable.weight > weight
                           orderby vegetable.weight descending
                           select vegetable;
            return (SaladCollection)NewCollection;
        }

        public static SaladCollection ColourFilter(SaladCollection Vegetables, string colour)
        {
            var NewCollection = from Vegetable vegetable in Vegetables
                           where vegetable.colour == colour
                           select vegetable;
            return (SaladCollection)NewCollection;
        }

        public static SaladCollection CaloriesFilter(SaladCollection Vegetables, double calories)
        {
            var NewCollection = from Vegetable vegetable in Vegetables
                           where vegetable.calories > calories
                           orderby vegetable.calories descending
                           select vegetable;
            return (SaladCollection)NewCollection;


        }

    }
}
