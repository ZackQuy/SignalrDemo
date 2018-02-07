using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建服务器监听  
            string url = "http://localhost:8000";
            using (WebApp.Start(url))
            {
                Console.WriteLine("Server runing on {0}", url);
                Console.Read();
            }  
        }
    }
}
