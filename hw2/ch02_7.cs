//编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和
using System;


namespace ch02_7
{
    class Program
    {   static void Main(string[] args)
        {
            //输入数组
            const int arrLength=5;  //数组长度，可以用户自定义
            int[] arr = new int[arrLength];
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Please input "+ arrLength + " numbers, the program will compute the maximum, minimum, sum and mean value.");
            for (int i = 0; i<arrLength; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            //计算
            int max=arr[0],min=arr[0],sum=arr[0];
            for (int i=1; i<arrLength; i++)
            {
                if(max<arr[i]){
                    max=arr[i];
                }
                if(min>arr[i]){
                    min=arr[i];
                }
                sum+=arr[i];  
            }
            Console.WriteLine("maximum="+max+", minimum="+min+", sum="+sum+", mean="+Convert.ToDouble(sum)/arrLength);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
