using System;

namespace ArrayLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(" ");
            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(" "), atemp => Convert.ToInt32(atemp));
            int[] result = rotateLeft(a, d);
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] rotateLeft(int[] a, int d)
        {
            int[] temp = new int[a.Length];
            int num = a.Length;
            int _d = d % num;
            for (int i = 0; i < num; i++)
            {
                temp[i] = a[i];
            }
            for (int i = d; i < num; i++)
            {
                a[i - d] = a[i];
            }
            for (int i = 0; i < d; i++)
            {
                a[num - d + i] = temp[i];
            }
            return a;
        }
    }
}
