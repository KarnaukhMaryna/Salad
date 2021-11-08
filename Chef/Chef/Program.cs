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
            Сabbage ca1 = new Сabbage();
            Onion o1 = new Onion(50);
            Carrot ct1 = new Carrot();

            SaladCollection salad = new SaladCollection();
            salad.Add(t1);
            salad.Add(t2);
            salad.Add(c1);
            salad.Add(ca1);
            salad.Add(o1);
            salad.Add(ct1);

            foreach (var s in salad)
            {
                Console.WriteLine(s);
            }

            salad.CaloriesInSalad();

            salad.RemoveAt(2);

            foreach (var s in salad)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
            Console.WriteLine("Vegetables in salad witch weight over 150 gram:");
            SaladCollection.ListOver150Gram(salad);

            Console.WriteLine("");
            Console.WriteLine("Vegetables in salad witch color is red:");
            string c = "red";
            SaladCollection.ListOfColor(salad, c);

            Console.WriteLine("");
            Console.WriteLine("Vegetables in salad witch calories under 40:");
            SaladCollection.ListUnder40Calories(salad);
        }

    }
}
