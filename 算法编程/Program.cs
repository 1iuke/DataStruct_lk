using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace 算法编程
{
    class Program
    {
        static void Main(string[] args)
        {

           GetLuckNum(1,20);
            Console.WriteLine("Hello World!");
            Console.Read();
        }

        public static void GetLuckNum(int a, int b)
        {
            if (a<0||a>1000000000)
            {
                throw new Exception("A Input is erroe");
            }

            if (b<a||b>1000000000)
            {
                throw new Exception("B Input is error");
            }

            for (int i = 1; i <= b - a + 1; i++)
            {

                int luck = i;
                //商是6或8  继续 
                //商是0  且余数是6或8 打印
                while (i / 10 == 6 || i / 10 == 8 || i / 10 == 0)
                {
                    i = i % 10;
                    if (i / 10 == 0 && i % 10 == 6 || i % 10 == 8)
                    {
                        Console.WriteLine(luck);
                        break;
                    }

                    break;
                }


            }





        }
    }
}
