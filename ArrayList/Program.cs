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

            arl.Add(3);
            arl.Add(1);
            arl.Add(2);

            //arl.Sort();
            arl.Reverse();

            foreach(int i in arl)
            {
                Console.WriteLine(i);   
            }

            Console.ReadLine();


        }
    }
}
