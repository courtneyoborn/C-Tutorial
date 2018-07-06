using System;

namespace WhileLoop
{
    class InfiniteDividor
    {
       
        //private int initalValue;
        ////data

        ////constrcutors
        //public InfiniteDividor()
        //{
        //    this.initalValue = 16;
        //}

        //public InfiniteDividor(int value) {
        //    this.initalValue = value;
        //}

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

