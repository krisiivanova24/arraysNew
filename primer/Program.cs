using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            for (int index = 0; index < arr.Length; index++)
            {
                Console.WriteLine("arr[{0}] = {1}", index, arr[index]);
            }
            Console.WriteLine(string.Join("--> \n", arr));
        }
    }
}
