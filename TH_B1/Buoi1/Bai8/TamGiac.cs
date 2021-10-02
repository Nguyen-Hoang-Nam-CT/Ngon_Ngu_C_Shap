using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class TamGiac
    {
        private double canh1, canh2, canh3, chuVi, dienTich;
        private String loaiTG;

        public double Canh1
        {
            set {canh1 = value;}
            get {return canh1;}
        }
        public double Canh2
        {
            set { canh2 = value; }
            get { return canh2; }
        }
        public double Canh3
        {
            set { canh3 = value; }
            get { return canh3; }
        }
        public double ChuVi
        {
            set { chuVi = value; }
            get { return chuVi; }
        }
        public double DienTich
        {
            set { dienTich = value; }
            get { return dienTich; }
        }
        public TamGiac()
        {
            canh1 = 2;
            canh2 = 3;
            canh3 = -5;
        }
        public TamGiac(float a, float b, float c)
        {
            canh1 = a;
            canh2 = b;
            canh3 = c;
        }
        public void tinhCV()
        {
            chuVi = canh1 + canh2 + canh3;
        }
        public void tinhDienTich()
        {
            double p = chuVi / 2;
            dienTich = Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
        }
        //tam giác đều là tam giác có 3 cạnh = nhau
        //tam giác cân là tam giác có tối thiểu 2 cạnh = nhau
        //tam giác vuôn là tam giác có bình phương cạnh huyển = tổng bình phương 2 cạnh gốc vuông
        //nếu bỏ qua tam giác nhọn và tù thì tam giác thường là các tam giác còn lại hihi
        public static Boolean CheckBinhPhuong(double a, double b, double c)
        {
            if (a * a == (b * b + c * c))
                return true;
            return false;
        }
        public static Boolean CheckTGVuong(double a, double b, double c)
        {
            if (CheckBinhPhuong(a, b, c) || CheckBinhPhuong(b, a, c) || CheckBinhPhuong(c, b, a))
                return true;
            return false;
        }
        public void input()
        {
            Console.Write("\nNhập cạnh 1: ");
            canh1 = float.Parse(Console.ReadLine());
            Console.Write("\nNhập cạnh 2: ");
            canh2 = float.Parse(Console.ReadLine());
            Console.Write("\nNhập cạnh 3: ");
            canh3 = float.Parse(Console.ReadLine());
            tinhCV();
            tinhDienTich();
            timLoaiTG();
        }
        public void display()//(hiển thị)
        {
            Console.Write("\nCạnh 1: " + canh1);
            Console.Write("\nCạnh 2: " + canh2);
            Console.Write("\nCạnh 3: " + canh3);
            Console.Write("\nChu vi: " + chuVi);
            Console.Write("\nDiện tích: " + dienTich);
            Console.Write("\nLoại tam giác: " + loaiTG);
        }
        public int XacDinhLoaiTG()
        {
            if(canh1 == canh2 && canh1 == canh3 && canh2 == canh3)
                return 1;
            else if((canh1 == canh2 || canh1 == canh3 || canh2 == canh3) && CheckTGVuong(canh1,canh2,canh3))
                return 2;
            else if((canh1 == canh2 || canh1 == canh3 || canh2 == canh3))
                return 3;
            else if(CheckTGVuong(canh1, canh2, canh3))
                return 4;
            else
                return 5;
        }
        public void timLoaiTG()
        {
            if (XacDinhLoaiTG() == 1)
                loaiTG = "Tam giác đều";
            else if (XacDinhLoaiTG() == 2)
                loaiTG = "Tam giác vuông cân";
            else if (XacDinhLoaiTG() == 3)
                loaiTG = "Tam giác cân";
            else if (XacDinhLoaiTG() == 4)
                loaiTG = "Tam giác vuông";
            else if (XacDinhLoaiTG() == 5)
                loaiTG = "Tam giác thường";
        }
    }
}
