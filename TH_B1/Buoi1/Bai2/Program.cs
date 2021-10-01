using System;

namespace Bai2
{
    class Program
    {
        
        public static int input()
        {
            return int.Parse(Console.ReadLine());
        }
        public static void nhapSoNguyenDuong(out int n)
        {
            Console.Write("\nNhập n: ");
            do
            {
                n = input();
                if (n < 0)
                    Console.Write("\nNhập n: ");
            } while (n < 0);
        }

        public static int timMax(int n)
        {
            int temp, max = int.MinValue;
            for(int i = 1; i <= n; i++)
            {
                Console.Write("\nNhập số thứ {0}: ", i);
                temp = input();
                max = max > temp ? max : temp;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            nhapSoNguyenDuong(out n);
            Console.Write("\nSố lớn nhất trong các số vừa nhập là: " + timMax(n));

            Console.ReadLine();
        }
    }
}
