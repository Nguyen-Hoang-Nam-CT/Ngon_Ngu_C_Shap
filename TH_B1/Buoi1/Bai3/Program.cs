using System;

namespace Bai3
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
        public static long tinhGiaiThua(int n)
        {
            int temp = 1;
            for(int i = 0; i < n; i++)
                temp *= (i + 1);
            return temp;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            nhapSoNguyenDuong(out n);
            Console.Write("\n Các số giai thừa từ 1 đến n là ");
            for(int i = 0; i < n; i++)
                Console.Write("\n {0} giai thừa = {1}",(i+1), tinhGiaiThua(i + 1));
        }
    }
}
