using System;

namespace UdemyTutorial
{
    class InfiniteDividor
    {
        static void Main(string[] args)
        {
            bool int1 = true;
            int input = int.Parse(Console.ReadLine());

            while (int1)
            {
                if (input % 2 == 0)
                {

                    input /= 2;
                    Console.WriteLine(input);

                }
                else
                {
                    int1 = false;
                }
            }
        }
    }
}

