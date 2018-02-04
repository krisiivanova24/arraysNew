using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naiSreshtanoChislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = arr.Length;
            int maxCommonElement = 0;                          //nai-chesto sreshtan
            int count = 1;
            int maxCount = 0;                                //nai-golqm broi
            for (int i = 0; i <= length - 2; i++)         //do predposlednoto
            {
                for (int j = i + 1; j <= length - 1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    maxCommonElement = arr[i];
                }
                count = 1;
            }



            Console.WriteLine($"{maxCommonElement} се среща {maxCount}");
        }
    }
}
