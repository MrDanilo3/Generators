using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    internal class SeriesTest
    {
        public static double Series(List<int> numbers)
        {
            int n = numbers.Count;
            double statisticalParameter;
            // Обчислити очікувану кількість інтервалів для кожного i
            double e_i;
            double eSum = 0;
            for (int i = 0; i < n; i++)
            {
                e_i = (n - i + 3) / Math.Pow(2, i + 2);
                if (e_i < 5)
                    break;
                eSum += e_i;
            }
            // Перебір вхідної послідовності для підрахунку блоків
            int s_length = 1;
            int B = 0;
            int G = 0;
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] == numbers[i - 1])
                    s_length++;
                else
                {
                    if (numbers[i - 1] == 0)
                        B += s_length;
                    else
                        G += s_length;
                    s_length = 1;
                }
            }
            // Перебір вхідної послідовності для підрахунку блоків
            double numeratorZero = Math.Pow(B - eSum, 2) / eSum;
            double numeratorOne = Math.Pow(G - eSum, 2) / eSum;
            statisticalParameter = numeratorZero + numeratorOne;
            return statisticalParameter;
        }
    }
}
