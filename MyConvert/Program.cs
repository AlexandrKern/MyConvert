using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConvert
{
    internal class Program
    {
        class MyConvert
        {
            private static int CharToInt(char c)
            {
                return c - '0';
            }
            public static double MyConvertDoubleResult(string str)
            {
                double result = 0;
                char c;
                int chek = 0;
                int del = 10;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i]==',')
                    {
                        chek = i;
                        continue;
                    }
                        result = result * 10 + CharToInt(str[i]);
                }
                if (chek!=0)
                {
                    chek = str.Length - 1 - chek;
                    for (int i = 0; i < chek - 1; i++)
                    {
                        del *= 10;
                    }
                    result /= del;
                }
                return result;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("В КАЧЕСТВЕ РАЗДЕЛИТЕЛЯ ИСПОЛЬЗОВАТЬ ЗАПЯТУЮ");
                Console.WriteLine("Введите число:");
                    string str = Console.ReadLine();
                    Console.WriteLine(MyConvertDoubleResult(str));
            }
        }
    }
}
