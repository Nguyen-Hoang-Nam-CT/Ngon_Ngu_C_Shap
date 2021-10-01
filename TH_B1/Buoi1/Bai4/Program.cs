using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        public static int input()
        {
            return int.Parse(Console.ReadLine());
        }
        public static void nhapSoLonHon1(out int n)
        {
            Console.Write("\nNhập n: ");
            do
            {
                n = input();
                if (n < 1)
                    Console.Write("\nNhập n: ");
            } while (n < 1);
        }
        public static void inputArray(int[] a, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("\nNhap so thu {0}: ", (i + 1));
                a[i] = input(); //gán giá trị vừa nhập vào phần tử thứ i
            }
        }
        public static void outputArray(int[] a, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write("{0,5}", a[i]);// số 5 là khoảng cách// in ra giá trị của a[i]
        }
        public static int findMin(int[] a, int size)
        {
            int min = a[0];
            for(int i = 0; i < size; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }
        public static int findMax(int[] a, int size)
        {
            int max = a[0];
            for (int i = 0; i < size; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        //ref là lấy vùng nhớ của biến mà mình truyền vào và thao tác trực tiệp trên vùng nhớ đó
        //==> giá trị được thay đổi

        //không có ref thì nó tạo ra một cái vùng nhớ ngẫu nhiên, xong sao chép giá trị của biến mình
        //truyền vào rồi thao tác trên vùng nhớ đó
        //==> giá trị không được thay đổi
        //ps: ref yêu cầu biến truyền vào phải có giá trị trước
        public static void swap(ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void sort(int[] a, int size)
        {
            int min;
            int temp;
            for(int i = 0; i < size - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < size; j++)
                    if (a[j] < a[min])
                        min = j;
                if(min != i)
                    swap(ref a[i],ref a[min]);
            }
        }
        public static int sum(int[] a, int size)
        {
            int SUM = 0;
            for (int i = 0; i < size; i++)
            {
                SUM += a[i];
            }
            return SUM;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            nhapSoLonHon1(out n);
            int[] array = new int[n];
            inputArray(array, n);
            Console.Write("\n Các phần tử có trong mảng là: ");
            outputArray(array, n);

            Console.Write("\nGía trị lớn nhất là: {0}", findMax(array, n));

            Console.Write("\nGía trị nhỏ nhất là: {0}", findMin(array, n));

            Console.Write("\n Thông tin mảng sau khi sắp xếp là: ");
            sort(array, n);
            outputArray(array, n);

            Console.Write("\n Tổng các phần tử trong mảng là: {0}", sum(array, n));
            Console.ReadKey();
        }
    }
}
