using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rectangle Application By. Milad Hassan Pour";
            double dblL, dblW, dblA, dblP;
            Console.Write("\n\t Enter Lenght:");
            dblL = Double.Parse(Console.ReadLine());
            Console.Write("\n\t Enter Width:");
            dblW = Double.Parse(Console.ReadLine());
            dblA = dblL * dblW;
            dblP = (dblL + dblW) * 2;
            Console.Write("\n\t Area={0}", dblA);
            Console.Write("\n\t Perimeter=");
            Console.Write(dblP);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.Write("\n\t      Length=");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write(dblL);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\t ┌────────────────┐");
            Console.Write("\n\t │                │ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Width=");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(dblW);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\t │                │ ");
            Console.Write("\n\t │                │ ");
            Console.Write("\n\t └────────────────┘");

            Console.ReadKey();


        }//Main
    }//Program
}//Rectangle
