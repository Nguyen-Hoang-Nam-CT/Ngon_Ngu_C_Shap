using System;

namespace Bai1
{
    class Program
    {
        public static int input()
        {
            return int.Parse(Console.ReadLine());
        }
        public static void nhapSoNguyenDuong(out int n)
        {
            do
            {
                n = input();
                if (n < 0)
                    Console.Write("\nNhập lại: ");
            } while (n < 0);
        }
        public static int findMax(int a, int b, int c)
        {
            int max = a > b ? a : b;
            return max > c ? max : c;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a, b, c;
            Console.Write("\nNhập a: ");
            nhapSoNguyenDuong(out a);
            Console.Write("\nNhập b: ");
            nhapSoNguyenDuong(out b);
            Console.Write("\nNhập c: ");
            nhapSoNguyenDuong(out c);

            Console.Write("\nSố lớn nhất là: " + Program.findMax(a, b, c));

            Console.ReadKey();

        }
    }
}
