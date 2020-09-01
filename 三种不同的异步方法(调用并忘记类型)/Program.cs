using System;
using System.Threading;
using System.Threading.Tasks;

namespace 三种不同的异步方法_调用并忘记类型_
{
    class Program
    {
        static void Main(string[] args)
        {
            DoAsyncStuff.CalculateSumAsync(5, 6);
            Thread.Sleep(200);
            Console.WriteLine("Program Exiting");

        }
        static class DoAsyncStuff
        {
            public static async void CalculateSumAsync(int i1,int i2)
            {
                int value = await Task.Run(() => GetSum(i1, i2));
                Console.WriteLine("Value:{0}", value);

            }
            private static int GetSum(int i1,int i2)
            {
                return i1 + i2;

            }
        }
    }
}
