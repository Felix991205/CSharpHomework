//用”埃氏筛法“求2-100以内的素数
using System;

namespace ch02_9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arrLength=100;
            //double squareRoot = Math.Pow(arrLength, 0.5);
            int[] arr=new int[arrLength];
            //初始化数组，1为合数，0为素数
            for(int i=0; i<arrLength; i++)
            {
                arr[i]=0;
            }
            //开始筛选
            arr[0]=1;
            for(int i=1; i<arrLength; i++)
            {
                int num=2*(i+1);
                while(num<=arrLength)
                {
                    arr[num-1]=1;
                    num+=i+1;
                }
            }
            //输出
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("100以内的素数有：");
            for(int i=0; i<arrLength; i++){
                if(arr[i]==0){
                    Console.Write((i+1).ToString() + " ");
                }
            }
            Console.Write("\n");
            Console.ForegroundColor=ConsoleColor.Black;

        }
    }
}
