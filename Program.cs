using System;
using System.Linq;
namespace Floor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] g = { 1, 2, 3, 4, 5, 6 };
          int r =  Primer(g);
            Console.WriteLine(r);
        }
        public static int Primer(int [] marks)
        {
            int rezult = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                double x = marks.Sum();
                int integer = (int)Math.Round(x);
                 rezult = integer / marks.Length;
            }
Console.WriteLine("Hello test Git Bash");
          return rezult;
        }
    }
}
