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
            Сabbage ca1 = new Сabbage(129);
            Onion o1 = new Onion(50);
            Carrot ct1 = new Carrot();

            SaladCollection salad = new SaladCollection();
            salad.Add(t1);
            salad.Add(t2);
            salad.Add(c1);
            salad.Add(ca1);
            salad.Add(o1);
            salad.Add(ct1);

            SaladCollection.OutputOnDisplay(salad);

            Console.Write("Calories in salad:");
            Console.WriteLine(Math.Round(salad.CaloriesInSalad(),2));

            salad.RemoveAt(2);          

            SaladCollection saladFilter = SaladCollection.ColourFilter(salad, "red");
            SaladCollection.OutputOnDisplay(saladFilter);

            saladFilter = SaladCollection.CaloriesFilter(salad, 50.00);
            SaladCollection.OutputOnDisplay(saladFilter);

        }
    }
}
