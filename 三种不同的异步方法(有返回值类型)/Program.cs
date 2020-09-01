using System;
using System.Threading.Tasks;

namespace 三种不同的异步方法_有返回值类型_
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> value = DoAsyncStuff.CalculateSumAsync(5, 6);
            Console.WriteLine("Value:{0}", value.Result);

        }
    }
    static class DoAsyncStuff
    {
        public static async Task<int> CalculateSumAsync(int i1,int i2)
        {
            int sum = await Task.Run(() => GetSum(i1, i2));
            return sum;
        }
        private static int GetSum(int i1,int i2)
        {
            return i1 + i2;

        }
    }
}
