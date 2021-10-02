using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        public static int input()
        {
            return int.Parse(Console.ReadLine());
        }
        public static void nhapSoLonHon1(out int n)
        {
            do
            {
                n = input();
                if (n < 1)
                    Console.Write("\nNhập lại: ");
            } while (n < 1);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int size;
            Console.Write("\n Nhập số lượng nhân viên: ");
            nhapSoLonHon1(out size);
            
            Staff[] StaffList = new Staff[size];
            for (int i = 0; i < StaffList.Length; i++)
            {
                Console.Write("\n Nhập thong tin nhân viên thứ {0}", (i + 1));
                StaffList[i] = new Staff();
                if (i == 0)
                    StaffList[i].setBasicSalary(500);
                StaffList[i].input();
                for(int j = 0; j < i; j++)
                {
                    if (StaffList[i].ID == StaffList[j].ID)
                    {
                        Console.Write("\nid đã tồn tại, nhập lại id: ");
                        StaffList[i].ID = int.Parse(Console.ReadLine());
                        j = 0;
                    }
                } 
            }
        }
    }
}
