using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Student
    {
        private String hoTen;
        private double diemToan, diemVan, diemTB;
        private int tuoi;

       
        public void input()
        {
            Console.Write("\nNhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("\nNhập tuổi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("\nNhập điểm toán: ");
            diemToan = float.Parse(Console.ReadLine());
            Console.Write("\nNhập điểm văn: ");
            diemVan = float.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.Write("\nHọ tên: {0}", hoTen);
            Console.Write("\nTuổi: {0}", tuoi);
            Console.Write("\nĐiểm toán: {0}", diemToan);
            Console.Write("\nĐiểm văn: {0} ", diemVan);
            Console.Write("\nĐiểm trung bình: {0}", diemTB);
        }
        public void tinhDiemTB()
        {
            diemTB = (diemToan + diemVan) / 2;
        }
    }
}
