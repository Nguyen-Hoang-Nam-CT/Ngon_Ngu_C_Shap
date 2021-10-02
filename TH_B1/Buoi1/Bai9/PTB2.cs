using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class PTB2
    {
        private double a, b, c, nghiem1, nghiem2;
        private String voNghiem = null;
        public PTB2()
        {
        }
        public PTB2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double A
        {
            get {return a; }
            set {a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public void input()
        {
            Console.Write("\nNhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nNhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\nNhap c: ");
            c = double.Parse(Console.ReadLine());
            tinhNghiem();
        }
        public void dislay()
        {
            if (voNghiem != null)
                Console.Write(voNghiem);
            else if(nghiem1 == nghiem2)
            {
                Console.Write("\n Phương trình có nghiệm kép: x1 = x2 = {0}", nghiem1);
            }
            else
            {
                Console.Write("\n Nghiệm của phương trình là: x1 = {0}, x2 = {1}", nghiem1, nghiem2);
            }
        }
        public static double denta(double a, double b, double c)
        {
            return (b * b - 4 * a * c);
        }
        public void tinhNghiem()
        {
            if (denta(a, b, c) < 0)
                voNghiem = "phương trình vô nghiệm";
            else if (denta(a, b, c) == 0)
                nghiem1 = nghiem2 = (-b) / (2 * a);
            else if(denta(a,b,c) > 0)
            {
                nghiem1 = (-b + Math.Sqrt(denta(a, b, c))) / (2 * a);
                nghiem2 = (-b - Math.Sqrt(denta(a, b, c))) / (2 * a);
            }
        }

    }
}
