// See https://aka.ms/new-console-template for more information
class Program
{
    static void PatternNumber1()
    {
        int len = 6;
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int k = 1; k < 2 * i - 1; k++)
            {
                Console.Write(" ");
            }
            if (i !=1)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int k = 1; k < 2 * i - 1; k++)
            {
                Console.Write(" ");
            }
            if (i != 1)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void PatternNumber2()
    {
        int[] nums = { 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6 };
        for (int i = 0; i <=10; i++)
        {
            for (int j = 0; j <= 10; j++)
            {
                if (j == i || j == 10 - i)
                    if (j % 2 != 0) Console.Write(nums[i]);
                    else Console.Write("*");
                else Console.Write(" ");
            }
            Console.WriteLine("\n");
        }
    }
    static void PatternNumber3()
    {
        int len = 5;
        for (int i = 1; i <= len; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i * j);
                if(j < i)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        for (int i = len -1; i >= 1 ; i--)
        {
            for (int k = 1; k <= i; k++)
            {
                Console.Write(i * k);
                if (k < i)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
    static void PatternNumber4()
    {
        int len = 6;
        for (int i = 1; i <= len; i++)
        {
            int val = i+1;
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(val + " ");
                val *= (2* j);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.WriteLine("Pattern Number 1");
        Console.WriteLine();
        PatternNumber1();
        Console.WriteLine("Pattern Number 2");
        Console.WriteLine();
        PatternNumber2();
        Console.WriteLine("Pattern Number 3");
        Console.WriteLine();
        PatternNumber3();
        Console.WriteLine("\n");
        Console.WriteLine();
        Console.WriteLine("Pattern Number 4");
        PatternNumber4();
    }
}