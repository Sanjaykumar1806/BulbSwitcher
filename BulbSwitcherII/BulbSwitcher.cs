using System;

namespace BulbSwitcher
{
    class BulbSwitcher
    {
        static void Main(string[] args)
        {
            var arr = new int[] {3, 2, 1, 5, 4 };
            Console.WriteLine(CountOfShine(arr));
            Console.Read();
        }
        public static int CountOfShine(int[] a)
        {
            var rightMax = -1;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                rightMax = Math.Max(rightMax, a[i]);
                if (i + 1 == rightMax)
                {
                    count += 1;
                }
            }
            return count;
        }
    }   
}
