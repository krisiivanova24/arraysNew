﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXnAbUKVA
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} -> {(int)arr[i]-97}");
            }
        }
    }
}
