using System;
using System.Collections;
using System.IO;
using WhileLoop;

namespace UdemyTutorial
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool unhide = true;
            while(unhide)
            {
                if (Console.ReadLine() == "scan")
                {
                    number++;
                    Console.WriteLine($"scanning file {number}");
                }
                
                else if (Console.ReadLine() == "hide")
                {
                    unhide = false;
                }
            }
            if(Console.ReadLine() == "game over")
            {
                Console.WriteLine("run");
                unhide = false;
                while (!unhide)
                {
                    if (Console.ReadLine() == "scan") 
                    {
                        Console.WriteLine("can't scan files for viruses");
                    }
                    else if(Console.ReadLine() == "unhide")
                    {
                        unhide = true;
                    }
                }
            }

        }
    }
}