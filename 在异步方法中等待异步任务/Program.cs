using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace 在异步方法中等待异步任务
{
    class MyDownLoadString
    {
        public void DoRun()
        {
            Task<int> t = CountCharactersAsync("https://www.microsoft.com/zh-cn/", "https://www.cnblogs.com/InCerry/p/9497729.html");
            Console.WriteLine("DoRun:Task{0}Finished", t.IsCompleted ? "" : "Not ");
            Console.WriteLine("DoRun:Result={0}", t.Result);

        }
        private async Task<int> CountCharactersAsync(string sitel,string site2)
        {
            WebClient wc1 = new WebClient();
            WebClient wc2 = new WebClient();
            Task<string> t1 = wc1.DownloadStringTaskAsync(new Uri(sitel));
            Task<string> t2 = wc2.DownloadStringTaskAsync(new Uri(site2));
            List<Task<string>> tasks = new List<Task<string>>();
            tasks.Add(t1);
            tasks.Add(t2);
            await Task.WhenAll(tasks);
            Console.WriteLine(" CCA:T1{0}Finished", t1.IsCompleted ? "" : "Not");
            Console.WriteLine(" CCA:T2{0}Finished", t2.IsCompleted ? "" : "Not");
            return t1.IsCompleted ? t1.Result.Length : t2.Result.Length;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDownLoadString ds = new MyDownLoadString();
            ds.DoRun();

        }
    }
}
