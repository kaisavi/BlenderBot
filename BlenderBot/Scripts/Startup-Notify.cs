using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using System.Diagnostics;
using System.Windows.Forms;
using DSharpPlus.Net.WebSocket;


namespace BlenderBot.Scripts
{
    class Notify
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var StartupForm = new StartupForm();
            Application.Run(StartupForm);
        }
            
            
                
        public static async Task MainAsync(string Token, ulong CID)
        {
            var discord = new DiscordClient(new DiscordConfiguration
            {
                Token = Token,
                TokenType = TokenType.Bot
            });
                DSharpPlus.Entities.DiscordChannel _channel = await discord.GetChannelAsync(CID);
                await discord.SendMessageAsync(_channel, "Render Complete! Keep up the good work!");

            discord.SetWebSocketClient<WebSocketSharpClient>();
            await discord.ConnectAsync();
        }
    }
}
