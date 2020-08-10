using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    // A Hub is a class that serves as a high-level pupline that handles client-server communications 
    //The ChatHub Class inherits from the SignalR HubClass , this manages the connection, groups, and messaging.
    public class ChatHub : Hub 
    {
        //The SendMessage method can be called by a connected client to send a message to call clients, 
        //Javascript client code call the method that is shown later. 
        // Asynchronous to provide maximum scalability.

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}