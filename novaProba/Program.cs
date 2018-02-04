using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novaProba
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, -5, 1, 10 };
            int[] arrReverse = new int[arr.Length];
            Array.Reverse(arr);
            arrReverse = arr;
            Console.WriteLine(string.Join(" ", arrReverse));

        }
    }
}
