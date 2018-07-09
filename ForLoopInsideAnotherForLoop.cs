using System;

namespace UdemyTutorial
{
    class ForLoopInsideAnotherForLoop
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string hashtag = "#";
            for (int i = 0; i < count; i++)
            {


                for (int j = 0; j < i; ++j)
                {
                    Console.Write(hashtag);
                }
                Console.WriteLine(hashtag);

            }
        }
    }
}








