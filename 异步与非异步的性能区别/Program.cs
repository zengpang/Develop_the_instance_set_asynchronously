using System;
using System.Diagnostics;
using System.Net;

namespace 异步与非异步的性能区别
{
    class MyDownloadString
    {
        Stopwatch sw = new Stopwatch();
        public void DoRun()
        {
            const int LargeNumber = 6000000;
            sw.Start();
            int t1 = CountCharacters(1, "https://www.microsoft.com/zh-cn/");
            int t2 = CountCharacters(2, "https://www.cnblogs.com/InCerry/p/9497729.html");
            CountToALargeNumber(1, LargeNumber);CountToALargeNumber(2, LargeNumber);
            CountToALargeNumber(3, LargeNumber);CountToALargeNumber(4, LargeNumber);
            Console.WriteLine("Chars in https://www.microsoft.com/zh-cn/ :{0}", t1);
            Console.WriteLine("Chars in https://www.cnblogs.com/InCerry/p/9497729.html :{0}",t2 );

        }
        
        private int CountCharacters(int id,string uriString)
        {
            WebClient wcl = new WebClient();
            Console.WriteLine("Starting call{0}:{1,4:NO}ms", id, sw.Elapsed.TotalMilliseconds);
            string result = wcl.DownloadString(new Uri(uriString));
            Console.WriteLine("Call{0} completed: {1,4:NO}ms", id, sw.Elapsed.TotalMilliseconds);
            return result.Length;

        }
        private void CountToALargeNumber(int id,int value)
        {
            for (long i = 0; i < value; i++)
                ;
            Console.WriteLine("End counting{0}:{1,4:No}ms", id, sw.Elapsed.TotalMilliseconds);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDownloadString ds = new MyDownloadString();
            ds.DoRun();

        }
     
    }
}
