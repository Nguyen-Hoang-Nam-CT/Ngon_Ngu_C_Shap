using System;
using System.Collections.Generic;
using System.Text;

namespace Giai_Phuong_Trinh_Bac_Nhat
{
    class Phuong_Trinh_Bac_Nhat
    {
        private int a;
        private int b;
        private double nghiem;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public void input()
        {
            Console.Write("\nNhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\nNhap b: ");
            b = int.Parse(Console.ReadLine());
        }

    }
}
