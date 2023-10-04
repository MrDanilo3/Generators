using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    internal class MonobitTest
    {
        public static double Monobit(List<int> numbers)
        {
            // Підрахувати кількість нулів та кількість одиниць
            int countOfZeros = numbers.Count(number => number == 0);
            int countOfOnes = numbers.Count(number => number == 1);
            // Обчислити статистичний параметр
            return Math.Pow(countOfZeros - countOfOnes, 2) / numbers.Count;
        }

    }
}
