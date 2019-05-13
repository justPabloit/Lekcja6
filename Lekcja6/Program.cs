using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wyświetl w konsoli prostokąt o szerokości x oraz wysokości y
            //x oraz y podaje użytkownik, prostokąt zbudowany jest z "*"

            Console.Write("Podaj szerokość: ");
            string xs = Console.ReadLine();
            Console.Write("Podaj wysokość");
            string ys = Console.ReadLine();

            int x = int.Parse(xs);
            int y = int.Parse(ys);

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j <x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(x+" "+y);

            Console.ReadKey();


        }
    }
}
