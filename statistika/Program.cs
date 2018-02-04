using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            //vyvejda element na arr
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = arr.Length;
            //obrabotka
            int min = int.MaxValue;
            int max = 0;
            float sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum = sum + arr[i];
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            //izvejdane na elementite na arr
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {sum/length}");
        }
    }
}
