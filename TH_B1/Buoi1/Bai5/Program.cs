using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        public static int nhapMotSo()
        {
            return int.Parse(Console.ReadLine());
        }
        //out cũng giống như ref những không cần gán giá trị cho biến trước khi truyền vào phương thức
        //out không quan tâm giá trị trước đó của biến, biến sẽ được gán giá trị trong phương thức nội tại (nếu muốn)
        public static void nhapSoNguyenDuong(out int n) 
        {
            do
            {
                n = nhapMotSo();
                if (n < 0)
                    Console.Write("\nNhập lại: ");
            } while (n < 0);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int NumberOfStudent;
            Console.Write("\n Nhập số lương sinh viên: ");
            nhapSoNguyenDuong(out NumberOfStudent);
            Student[] StudentList = new Student[NumberOfStudent];
            for(int i = 0; i < StudentList.Length; i++)
            {
                Console.Write("\nNhập thông tin sinh viên thứ {0}", (i + 1));
                StudentList[i] = new Student();
                StudentList[i].input();
                StudentList[i].tinhDiemTB();
            }

            for(int i = 0; i < StudentList.Length; i++)
            {
                Console.Write("\nThông tin sinh viên thứ {0}", (i + 1));
                StudentList[i].output();
            }
            Console.ReadKey();
        }
    }
}
