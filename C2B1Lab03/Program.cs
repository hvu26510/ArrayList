using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2B1Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arl = new ArrayList();

            //Nhập ArrayList
            int count = 1;
            while (true)
            {
                Console.WriteLine("Nhap phan thu thu: " + count);
                Console.WriteLine("Nhap 'q' de dung ");
                string str = Console.ReadLine();
                if (str == "q") break;

                // thêm giá trị nhập vào ArrayList
                arl.Add(int.Parse(str));
            }

            // Xuat mang
            Console.WriteLine("Mang vua nhap:");
            foreach (int i in arl)
            {
                Console.Write(i + "     ");
            }
            Console.WriteLine();

            // tang dan
            Console.WriteLine("Mang tang dan:");
            arl.Sort();
            foreach (int i in arl)
            {
                Console.Write(i + "     ");
            }
            Console.WriteLine();

            //giam dan
            arl.Reverse();
            Console.WriteLine("Mang giam dan:");
            foreach (int i in arl)
            {
                Console.Write(i + "     ");
            }
            Console.WriteLine();

            // nho nhat
            Console.WriteLine("Min = " + arl[arl.Count - 1]);

            // tinh tbc
            count = 0;
            int tong = 0;
            foreach (int i in arl)
            {
                if (i % 3 == 0)
                {
                    tong = tong + i;
                    count++;
                }
            }
            Console.WriteLine("TCB phan tu chia het cho 3: " + (tong * 1.0 / count));

            Console.ReadLine();
        }
    }
}
