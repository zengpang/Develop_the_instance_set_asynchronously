using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Delay方法
{
    class Simple
    {
        Stopwatch sw = new Stopwatch();
        public void DoRun()
        {
            Console.WriteLine("Caller:Before Call");
            ShowDelayAsync();
            Console.WriteLine("Caller:Atrer Call");

            
        }
        private async void ShowDelayAsync()
        {
            sw.Start();
            Console.WriteLine("Before Delay:{0}", sw.ElapsedMilliseconds);
            await Task.Delay(1000);
            Console.WriteLine("After Delay:{0}", sw.ElapsedMilliseconds);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Simple ds = new Simple();
            ds.DoRun();
            Console.Read();
        }
    }
}
