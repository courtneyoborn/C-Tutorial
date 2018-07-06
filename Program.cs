using System;
using System.Collections;
using System.IO;

namespace UdemyTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
           bool int1 = true;
            int input = int.Parse(Console.ReadLine());
            
            while(int1)
            {
                if(input %2 == 0)
                {
                    Console.WriteLine(input / 2);
                }
            }
            int1 = false;
                    
        }
    }
}




 
