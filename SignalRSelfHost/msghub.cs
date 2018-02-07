using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRSelfHost
{
    public class msgHub : Hub
    {

        /// <summary>  
        /// 向所有客户端发送消息或转发消息  
        /// </summary>  
        /// <param name="content"></param>  
        public void send(string content)
        {
            Console.WriteLine("服务器中转内容：" + content);
            //通知所有客户端  
            Clients.All.receive(content);
        } 
    }
}
