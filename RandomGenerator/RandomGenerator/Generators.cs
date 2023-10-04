using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerator
{
    internal class Generators
    {
        public static List<int> NumbersGenerator(int amount)
        {
            List<int> result = new List<int>();
            Random random = new Random();
            for (int i = 0; i < amount; i++)
                result.Add(random.Next(2));
            return result;
        }
    }
}
