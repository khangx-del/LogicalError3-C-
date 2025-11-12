using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalError3_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]  {1, 2, 3, 4, 5 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];            
            }
            
            Console.WriteLine("Sum of numbers: " + sum);
            Console.ReadLine();
        }
    }
}
