using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello world!!");
            Console.ForegroundColor= ConsoleColor.Black;
            Console.BackgroundColor= ConsoleColor.White;
            Console.WriteLine("Hello world!!!");
            Console.ResetColor();
            Console.WriteLine("Hello world!!!");
            //Delay
            Console.ReadLine(); 
        }
    }
}
