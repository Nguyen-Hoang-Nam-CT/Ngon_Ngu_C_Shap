using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime timenow = System.DateTime.Now;
            Console.WriteLine("\t goi ham tao khong tham so");
            ThoiGian t1 = new ThoiGian();

            t1.showTime();
            ThoiGian t2 = new ThoiGian(30, 09, 2013, 21, 00, 00);
            t2.showTime();
            ThoiGian t3 = new ThoiGian(20, 05, 2013);
            t3.showTime();
            ThoiGian t4 = new ThoiGian(t3);
            t4.showTime();
            ThoiGian t5 = new ThoiGian(timenow);
            t5.showTime();
            Console.ReadKey();
        }
    }
}
