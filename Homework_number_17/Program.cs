using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maximumRandomNumber = 100;
            int minimalRandomNumber = 1;
            int randomNumber = random.Next(minimalRandomNumber, maximumRandomNumber);
            int minimumPower = 1;
            int degree = 2;

            while (Math.Pow(degree, minimumPower) <= randomNumber)
            {
                minimumPower++;
            }

            Console.WriteLine($"Случайное  число: {randomNumber}");
            Console.WriteLine($"Минимальная кратность из числа: {minimumPower}");
        }
    }
}
