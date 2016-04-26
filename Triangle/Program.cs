using System;
namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallTriangle = TriangleParser.Parse("Triangle1.txt");
            if (smallTriangle != null)
            {
                Console.WriteLine("Small triangle sum = {0}", TriangleCounter.FindMaxSum(smallTriangle));
            }

            var bigTriangle = TriangleParser.Parse("Triangle2.txt");
            if (smallTriangle != null)
            {
                Console.WriteLine("Big triangle sum = {0}", TriangleCounter.FindMaxSum(bigTriangle));
            }

            Console.ReadKey();
        }
    }
}
