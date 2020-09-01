using System;
using System.Threading.Tasks;

namespace 自建await表达式方法_创建名为ten的Func委托_
{
    class MyClass
    {
        public int Get10()
        {
            return 10;
        }
        public async Task DoWorkAsync()
        {
            Func<int> ten = new Func<int>(Get10);
            int a = await Task.Run(ten);
            int b = await Task.Run(new Func<int>(Get10));
            int c = await Task.Run(() => { return 10; });
            Console.WriteLine("{0} {1} {2}", a, b, c);

        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Task t = (new MyClass()).DoWorkAsync();
            t.Wait();

        }
    }
}
