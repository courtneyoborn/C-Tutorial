using System;

namespace WhileLoop
{
    class InfiniteDividor
    {
        public void PrintPowersOfTwo()
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

