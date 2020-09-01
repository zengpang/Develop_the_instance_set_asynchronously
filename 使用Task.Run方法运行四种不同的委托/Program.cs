using System;
using System.Threading.Tasks;

namespace 使用Task.Run方法运行四种不同的委托
{
    static class MyClass
    {
        public static async Task DoWorkAsync()
        {
            await Task.Run(() => Console.WriteLine(5.ToString()));
            Console.WriteLine((await Task.Run(() => 6)).ToString());
            await Task.Run(() => Task.Run(() => Console.WriteLine(7.ToString())));
            int value = await Task.Run(() => Task.Run(() => 8));
            Console.WriteLine(value.ToString());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task t = MyClass.DoWorkAsync();
            t.Wait();
            Console.WriteLine("Press Enter key to exit");
            Console.Read();

        }
    }
}
