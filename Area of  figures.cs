using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if(figureType == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double S = a * a;
                Console.WriteLine(Math.Round(S,3));
            }
            if (figureType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = a * b;
                Console.WriteLine(Math.Round(S, 3));
             }
            if (figureType == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double S = Math.PI * r * r;
                Console.WriteLine(Math.Round (S, 3));
            }
            //if (figureType == "triangle")
            //{
            //    double a = double.Parse(Console.ReadLine());
            //    double h = double.Parse(Console.ReadLine());
            //    double S = a * h / 2;
            //    Console.WriteLine(Math.Round(S, 3));
            //}


        }
    }
}
