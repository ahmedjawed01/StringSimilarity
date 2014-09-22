using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentageSimilarity
{
    class Program
    {
        static void Main(string[] args)
        {
            string source, target;
            while (true)
            {
                Console.Write("Please enter source string: ");
                source = Console.ReadLine();
                Console.Write("Please enter target string: ");
                target = Console.ReadLine();


                Console.WriteLine("{0}%", source.ToLower().CalculateSimilarity(target.ToLower()) * 100);
            }
        }
    }
}