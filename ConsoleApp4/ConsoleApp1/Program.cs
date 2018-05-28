using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person_1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person ni = new Person();
            string s1 = "zhangsan";
            string s2 = "dsadasdasdasd ";
            string s3 = "zhangsan";
            string d4 = "wannnn"
	        string s5 = "wangwu";
            
            string s = null;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int i = 0; i<100000; i++)
            {
                s += i;
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            char[] d = s3.ToCharArray();
            Console.WriteLine(s3[3]);
            d[3] = 'd';

            Console.WriteLine("{0} {1}", s3, d[3]);
            Console.ReadKey();
        }
    }
}
