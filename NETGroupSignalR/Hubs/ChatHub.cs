using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace NETGroupSignalR.Hubs
{
    public class ChatHub : Hub
    {
        private static int count = 0;
        public override Task OnConnected()
        {
            count++;
            Clients.All.updateCount(count);
            return base.OnConnected();
        }
		
		public void Join(string name)
        {
            Clients.Others.userJoined(name);
        }

        public void SendMessage(string name, string message)
        {
            Clients.Others.onReceiveMessage(name, message);
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            count--;
            Clients.All.updateCount(count);
            return base.OnDisconnected(stopCalled);
        }
    }
}