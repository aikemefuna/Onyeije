using Microsoft.AspNetCore.SignalR;
using OnyeijeIgboAcademy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Hubs
{
    public class ChatHubs : Hub
    {
        //public Task SendPrivateMessage(string user, string message)
        //{
        //    return Clients.User(user).SendAsync("ReceiveMessage", message);

        //}
        public async Task SendMessage(Message message) =>
         await Clients.All.SendAsync("receiveMessage", message);
    }
}
