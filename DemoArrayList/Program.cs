using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrayList
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

            count = 0;
            // Đếm số phần tử chia hết cho 2
            foreach(int phantu in arl)
            {
                if(phantu %2==0) count++;
            }
            Console.WriteLine($"So phan tu chan : {count}");


            // Loại bỏ các phần tử chẵn
            for(int i = 0; i < arl.Count; i++)
            {
                int x = Convert.ToInt32(arl[i].ToString());
                if (x % 2 == 0)
                {
                    // loại bỏ phần tử ở vị trí i
                    arl.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine("Sau khi loai so chan:");
            foreach(int phantu in arl)
            {
                Console.Write(phantu +"     ");
            }

            Console.ReadLine();


        }
    }
}
