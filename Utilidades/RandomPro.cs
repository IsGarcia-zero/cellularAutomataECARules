using System;
using System.Collections.Generic;

namespace Regla30.Utilidades
{
    internal class RandomPro
    {
        private static Random _random = new Random();
        private static readonly object syncLock = new object();

        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            {
                return _random.Next(min, max);
            }
        }

        public string GenerateRandomBinaryString(Int64 length, double probability)
        {
            if (probability < 0 || probability > 1)
            {
                throw new ArgumentException("La probabilidad debe estar entre 0 y 1.");
            }

            List<char> binaryString = new List<char>();

            for (Int64 i = 0; i < length; i++)
            {
                double randomValue = _random.NextDouble();
                char bit = randomValue < probability ? '1' : '0';
                binaryString.Add(bit);
            }

            return new string(binaryString.ToArray());
        }
    }
}
