using System;

namespace Chef
{
    class Program
    {
        static void Main(string[] args)
        {
            Tomatoe t1 = new Tomatoe(130);
            Tomatoe t2 = new Tomatoe();
            Cucumber c1 = new Cucumber();

            SaladCollection salad = new SaladCollection();
            salad.Add(t1);
            salad.Add(t2);
            salad.Add(c1);

            foreach (var s in salad)
            {
                Console.WriteLine(s);
            }

            salad.CaloriesInSalad();

        }
    }
}
