using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] destination =  { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
            Array.Copy(source, 4, destination, 2, 3);
            Console.WriteLine(string.Join(" ", destination));
        }
    }
}
