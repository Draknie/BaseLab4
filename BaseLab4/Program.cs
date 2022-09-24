using System;

namespace BaseLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M = new int[100];
            Random rand = new
                Random(DateTime.Now.Millisecond);
            Random n = new Random(2);
            int x;
            Console.WriteLine("100 рандомных чисел");
            for (x = 0; x < M.Length; x++)
            {
                int r = rand.Next(1001);
               
                M[x] = rand.Next(2)==0? r : -r;
                Console.Write(M[x] + ", ");
            }
            Console.WriteLine("\nРандомные четные числа");
            for(x=0; x < M.Length; x++)
            {
                if(M[x] % 2 == 0)
                {
                    Console.Write(M[x] + ", ");
                }
            }
            Console.WriteLine("\nРаномные числа кратные трем");
            for (x = 0; x < M.Length; x++)
            {
                if (M[x] % 3 == 0)
                {
                    Console.Write(M[x] + ", ");
                }
            }
            Console.WriteLine("\nСумма отрицательных чисел");
            int t = 0;
            for(x = 0; x < M.Length; x++)
            {
                if (M[x] < 0)
                {
                    t = t + M[x];
                }
            }
            Console.WriteLine(t);
        }
    }
}
