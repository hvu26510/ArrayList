using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai báo array list
            ArrayList arl = new ArrayList();

            arl.Add("nguyen van a");
            arl.Add(10);
            arl.Add(true);

            Console.WriteLine("vi tri cua true: " + arl.IndexOf(true));

            //Console.WriteLine(arl[0]);
            //Console.WriteLine(arl[1]);
            //Console.WriteLine(arl[2]);

            Console.ReadLine();


        }
    }
}
