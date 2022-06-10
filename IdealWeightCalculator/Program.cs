using System;

namespace IdealWeightCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            WeightCalculator weightCalculator = new WeightCalculator
            {
                Height = 162,
                Sexe = 'w'
            };

            double weight = weightCalculator.GetIdealBodyWeight();
            Console.WriteLine($"The Ideal Body Weight is: {weight}");
            Console.ReadKey();
        }
    }
}
