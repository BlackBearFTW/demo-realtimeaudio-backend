using Microsoft.AspNetCore.SignalR;

namespace AudioStream_SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(byte[] message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
