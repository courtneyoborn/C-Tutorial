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
            bool hide = false;
            while(Console.ReadLine() == "scan")
            {
                if (Console.ReadLine() == "scan")
                {
                    number++;
                    Console.WriteLine($"scanning file {number}");
                }

                else if (Console.ReadLine() == "hide")
                {
                    unhide = false;
                    hide = true;
                }  
            }

            while (hide)
            {
                if (Console.ReadLine() == "hide")
                {
                    if (Console.ReadLine() == "scan")
                    {
                        Console.WriteLine("can't scan files for viruses");
                    }
                            
                }
            }

            if (Console.ReadLine() == "game over")
            {
                Console.WriteLine("run");
            }

        }
    }
}