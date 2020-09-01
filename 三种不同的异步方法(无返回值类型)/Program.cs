using System;
using System.Threading.Tasks;

namespace 三种不同的异步方法_无返回值类型_
{
    class Program
    {
        static void Main(string[] args)
        {
            Task someTask = DoAsyncStuff.CalculateSumAsync(5, 6);
            someTask.Wait();
            Console.WriteLine("Async stuff is done");

        }
        static class DoAsyncStuff
        {
            public static async Task CalculateSumAsync(int i1,int i2)
            {
                int value = await Task.Run(() => GetSum(i1, i2));
                Console.WriteLine("Async stuff is done");

            }
            private static int GetSum(int i1,int i2)
            {
                return i1 + i2;

            }
        }

    }
}
