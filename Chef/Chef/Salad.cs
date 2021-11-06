using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
            Console.WriteLine(Sum);
        }
    }
}
