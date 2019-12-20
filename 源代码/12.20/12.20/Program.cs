using System;

namespace _12._20
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int j = 0;
            int a = 0;
            string[,] strl =
            {
                {"张三","2","3","张三" },
                {"张三","2","3","张三" },
                {"张三","2","3","张三" }
            };
            foreach (string i in strl)
            {
                if (j == 2)
                {
                    j = 0;
                    a++;
                }
                if (i == str)
                {
                    Console.WriteLine("坐标在" + j + a);
                }
                j++;

                continue;
            }
            Console.ReadLine();
        }
    }
}
