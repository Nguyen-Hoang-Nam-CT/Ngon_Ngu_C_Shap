using System;

namespace Giai_Phuong_Trinh_Bac_Nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Phuong_Trinh_Bac_Nhat pt1 = new Phuong_Trinh_Bac_Nhat();
            pt1.input();
            if (pt1.A == 0)
            {
                if (pt1.B == 0)
                    Console.Write("\nPhuong trinh co vo so nghiem");
                else
                    Console.Write("\nPhuong trinh vo nghiem");
            }
            else
            {
                Console.Write("\nPhuong trinh co nghiem: " + (double)(-pt1.B / pt1.A));
            }
            Console.ReadKey();
        }
    }
}
