using System;

public class WhileLoop
{
	public WhileLoop()
	{
        bool flag = true;
        int salary = 100;
        Console.WriteLine($"I will give you {salary} dollars, ok?");

        while (flag)
        {
            string input = Console.ReadLine();


            if (input == "more")
            {
                salary += 100;
                Console.WriteLine($"I will give you {salary}, ok?");
            }

            else if (input == "ok")
            {
                Console.WriteLine($"Your salary is {salary} dollars.");
                flag = false;

            }
        }
    }
}
