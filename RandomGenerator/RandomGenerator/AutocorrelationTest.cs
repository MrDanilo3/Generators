using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    class AutocorrelationTest
    {
        public static double Autocorrelation(List<int> numbers)
        {
            int n = numbers.Count;
            double statisticalParameter;
            // Обчислити суму квадратів різниць
            double sumSquares = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int diff = numbers[i] - numbers[i + 1];
                sumSquares += diff * diff;
            }
            // Обчислити статистичний параметр
            statisticalParameter = Math.Sqrt(2 * sumSquares / (n - 1));
            return statisticalParameter;
        }
    }
}
