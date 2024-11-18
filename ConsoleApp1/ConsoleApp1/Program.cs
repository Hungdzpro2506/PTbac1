﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double ketqua = -b / a;
                Console.WriteLine("Nghiem phuong trinh la"+ketqua);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("Nghiem dung voi moi x");
                }
                else
                {
                    Console.Write("Vo nghiem!");
                }
            }
        }
    }
}
