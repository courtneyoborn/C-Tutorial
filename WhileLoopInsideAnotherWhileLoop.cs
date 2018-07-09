using System;

namespace UdemyTutorial
{
    class WhileLoopInsideAnotherWhileLoop
    {
        static void WhileLoopTriangle()
        {
            int count = int.Parse(Console.ReadLine());
            string hashtag = "#";
            int i = 0;
            int j = 0;
            while (i < count)
            {
                i++;
                while (j < i)
                {
                    j++;
                    Console.Write(hashtag);

                }
                j = 0;
                Console.WriteLine();
            }
        }
    }
}