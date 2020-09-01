using System;
using System.Net;
using System.Threading.Tasks;

namespace 在调用方法中同步等待异步方法完成
{
    static class MyDownloadString
    {
        public static void DoRun()
        {
            Task<int> t = CountChararctersAsync("https://www.microsoft.com/zh-cn/");
            t.Wait();
            Console.WriteLine("The task has finshed,returning value{0}", t.Result);

        }
        private static async Task<int> CountChararctersAsync(string site)
        {
            string result = await new WebClient().DownloadStringTaskAsync(new Uri(site));
            return result.Length;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDownloadString.DoRun();

        }
    }
}
