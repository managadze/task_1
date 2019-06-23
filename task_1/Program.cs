using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long n, k, m;
            string s;
            string[] split;
            s = Console.ReadLine();
            split = s.Split(new char[] { ' ' });
            long.TryParse(split[0], out k);
            for (int i = 0; i < k; i++)
            {
                s = Console.ReadLine();
                split = s.Split(new char[] { ' ' });
                long.TryParse(split[0], out n);
                long.TryParse(split[1], out m);
                if (n == 1) Console.WriteLine("No");
                else if (((n - 1) * (n - 2)) >= (2 * m)) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
        }
    }
}
