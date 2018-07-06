using System;
using System.Collections;
using System.IO;
using WhileLoop;

namespace UdemyTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            string hashtag = "#";
            for (int i = 0; i < count; i++)
            {
                string answer = hashtag + "#";
                for (int j=0; j <= i; ++j)
                {
                    
                    Console.WriteLine(answer);
                }
                

            }
            



        }
    }
}




 
