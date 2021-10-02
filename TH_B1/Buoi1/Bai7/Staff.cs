using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Staff
    {
        private int id, yearOfBith;         // năm sinh
        private String name;                // họ tên
        private double salaryLevel, InCome; // (hệ số lương, thu nhập)
        private static double basicSalary;  //lương cơ bản
        
        private int count = 0;
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public int getYearOfBith()
        {
            return yearOfBith;
        }
        public String getName()
        {
            return name;
        }
        public double getInCome()
        {
            return InCome;
        }
        public void setBasicSalary(double luongCoBan)
        {
            basicSalary = luongCoBan;
        }
        public void setSalaryLevel(double heSoLuong)
        {
            salaryLevel = heSoLuong;
        }
        public void input()
        {
            Console.Write("\n Nhập id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("\n Nhập họ tên: ");
            name = Console.ReadLine();
            Console.Write("\n Nhập năm sinh (Year of bith): ");
            yearOfBith = int.Parse(Console.ReadLine());
            Console.Write("\n Nhập hệ số lương (Salary level): ");
            salaryLevel = double.Parse(Console.ReadLine());
            tinhLuong();
        }
        public void Display()
        {
            Console.Write("\n Id: " + id);
            Console.Write("\n Name: " + name);
            Console.Write("\n Năm sinh (Year Of Bith): " + yearOfBith);
            Console.Write("\n Hệ số lương (Salary Level): " + salaryLevel);
            Console.Write("\n Lương cơ bản (basic Salary): " + basicSalary);
            Console.Write("\n Thu nhập (In Come): " + InCome);
        }
        public void tinhLuong()
        {
            InCome = salaryLevel * basicSalary;
        }
    }
}
