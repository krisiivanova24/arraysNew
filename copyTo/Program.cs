using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, -5, 1, 10 };
            int[] arr2 = { 6, 7, 8 };
            arr2.CopyTo(arr, 1);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
