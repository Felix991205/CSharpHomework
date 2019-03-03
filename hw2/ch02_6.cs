//编写程序输出指定数字的所有素数因子
using System;
using System.Collections;

namespace ch02_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number, then the program will find its prime factors.");
            String str=Console.ReadLine();
            Int32 input=Convert.ToInt32(str);
            //先找到小于等于input的所有素数因子
            ArrayList primes=new ArrayList();
            for(int i=2;i<input;i++)
            {
                Boolean flag=true;
                for(int j=2;j<i;j++)
                {
                    if(i%j==0){
                        flag=false;
                        break;
                    }
                }
                if(flag){
                    primes.Add(i);
                }
            }
            //再依次判断input有没有该素数因子
            Console.Write("素数因子有：");
            foreach (int prime in primes)
            {
                if(input%prime==0){
                    Console.Write(Convert.ToString(prime)+" ");
                }
            }
            Console.Write("\n");
        }
    }
}
