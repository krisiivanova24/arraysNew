﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clear
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, -5, 1, 10 };
            Array.Clear(arr, 0, 1);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
