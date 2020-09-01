using System;
using System.Threading.Tasks;

namespace 异步方法_Lamda表达式_
{
    static class MyClass
    {
        private static int GetSum(int i1,int i2)
        {
            return i1 + i2;

        }
        public static async Task DoWorkAsync()
        {
            int value = await Task.Run(() => GetSum(5, 6));
            Console.WriteLine(value.ToString());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task t = MyClass.DoWorkAsync();
            t.Wait();
            Console.WriteLine("press Enter Key to Exit");
            Console.Read();

        }
    }
}
