using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    internal class PokerTest
    {
        public static double Poker(List<int> numbers)
        {
            // Обчислити m - оптимальну кількість частин, на які потрібно розбити список
            // Обчислюється змінна k (підраховується кількість чисел у кожній частині)
            int m = 1;
            while (numbers.Count / Math.Pow(2, m) < 5)
                m++;
            int k = numbers.Count / m;
            // Цикл для підрахунку кількості кожної деталі
            Dictionary<string, int> typeCounts = new();
            for (int i = 0; i < k; i++)
            {
                List<int> part = numbers.GetRange(i * m, m);
                string partString = string.Join("", part);
                if (typeCounts.ContainsKey(partString))
                    typeCounts[partString]++;
                else
                    typeCounts[partString] = 1;
            }
            // Для кожної унікальної частини обчислюється кількість її входжень, підноситься до квадрату і додається до sumOfSquares
            double sumOfSquares = 0;
            foreach (var count in typeCounts.Values)
                sumOfSquares += Math.Pow(count, 2);
            // Обчислити статистичний параметр
            return Math.Pow(2, m) / k * sumOfSquares - k;
        }

    }
}
