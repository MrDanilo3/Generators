using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerator
{
    internal class TwoBitTest
    {
        public static double TwoBit(List<int> numbers)
        {
            // Підрахувати кількість нулів та кількість одиниць
            int countOfZeros = numbers.Count(number => number == 0);
            int countOfOnes = numbers.Count(number => number == 1);
            // Підрахувати кількість пар 00, 01, 10, 11
            int count00 = 0, count01 = 0, count10 = 0, count11 = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == 0 && numbers[i + 1] == 0)
                    count00++;
                else if (numbers[i] == 0 && numbers[i + 1] == 1)
                    count01++;
                else if (numbers[i] == 1 && numbers[i + 1] == 0)
                    count10++;
                else if (numbers[i] == 1 && numbers[i + 1] == 1)
                    count11++;
            }
            // Обчислити статистичний параметр
            return 4.0 / (numbers.Count - 1) * (Math.Pow(count00, 2) +
           Math.Pow(count01, 2) + Math.Pow(count10, 2) + Math.Pow(count11, 2))
            - 2.0 / numbers.Count * (Math.Pow(countOfZeros, 2) +
           Math.Pow(countOfOnes, 2)) + 1;
        }

    }
}
