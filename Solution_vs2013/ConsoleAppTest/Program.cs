﻿using ConsoleAppTest.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运行中...");

            new ListTest().Do();

            Console.ReadKey();
        }
    }
}
