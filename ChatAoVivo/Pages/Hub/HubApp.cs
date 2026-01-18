using Microsoft.AspNetCore.SignalR;

namespace ChatAoVivo.Hubs
{
    public sealed class HubApp : Hub
    {
        public async Task SendMessage(models.Messages messages)
        {
            await Clients.All.SendAsync("ReceiveMessage", messages.User, messages.Message);
        }

        
    }
}