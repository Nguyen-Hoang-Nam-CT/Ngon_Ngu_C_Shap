using System;

namespace Bai1
{
    class Program
    {
        public static int findMax(int a, int b, int c)
        {
            int max = a > b ? a : b;
            return max > c ? max : c;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a, b, c;
            System.Console.Write("\nNhập a: ");
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a < 0)
                    System.Console.Write("\nNhập lại a: ");
            } while (a < 0);
            
            System.Console.Write("\nNhập b: ");
            do
            {
                b = int.Parse(Console.ReadLine());
                if (b < 0)
                    System.Console.Write("\nNhập lai b: ");
            } while (b < 0);
            
            System.Console.Write("\nNhập c: ");
            do
            {
                c = int.Parse(Console.ReadLine());
                if (c < 0)
                    System.Console.Write("\nNhập lại c: ");
            } while (c < 0);

            Console.Write("\nSố lớn nhất là: " + Program.findMax(a, b, c));

            Console.ReadKey();

        }
    }
}
