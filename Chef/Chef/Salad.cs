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

        public static void ListOver150Gram(SaladCollection List)
        {
            var ListOver = from Vegetable vegetable in List
                           where  vegetable.weight > 150
                           orderby vegetable.weight descending
                           select vegetable;
            foreach (var vegetable in ListOver)
            {
                Console.WriteLine(vegetable);
            }
        }

        public static void ListUnder150Gram(SaladCollection List)
        {
            var ListOver = from Vegetable vegetable in List
                           where vegetable.weight < 150
                           orderby vegetable.weight descending
                           select vegetable;
            foreach (var vegetable in ListOver)
            {
                Console.WriteLine(vegetable);
            }
        }

        public static void ListOfColor(SaladCollection List, string colour)
        {
            var ListOver = from Vegetable vegetable in List
                           where vegetable.colour == colour
                           select vegetable;
            foreach (var vegetable in ListOver)
            {
                Console.WriteLine(vegetable);
            }
        }

        public static void ListOver40Calories(SaladCollection List)
        {
            var ListOver = from Vegetable vegetable in List
                           where vegetable.calories > 40
                           orderby vegetable.calories descending
                           select vegetable;
            foreach (var vegetable in ListOver)
            {
                Console.WriteLine(vegetable);
            }
        }

        public static void ListUnder40Calories(SaladCollection List)
        {
            var ListOver = from Vegetable vegetable in List
                           where vegetable.calories < 40
                           orderby vegetable.calories descending
                           select vegetable;
            foreach (var vegetable in ListOver)
            {
                Console.WriteLine(vegetable);
            }
        }

    }
}
