using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int finalRate = 1;
            int minNumber = 1;
            int maxNumber = 100;
            int numberForDegree = 2;
            int numberAfterRate = numberForDegree;
            int numberForCompare = random.Next(minNumber, maxNumber);
            bool isWork = true;

            while (isWork)
            {
                numberAfterRate *= numberForDegree;
                
                if (numberAfterRate > numberForCompare)
                {
                    Console.WriteLine($"Для числа {numberForCompare} - {numberForDegree} будет в степени {finalRate} и это число - {numberAfterRate}. {numberForCompare} < {numberAfterRate}");

                    isWork = false;
                } 
                else
                {
                    finalRate++;
                }
            }
            Console.ReadKey();
        }
    }
}
