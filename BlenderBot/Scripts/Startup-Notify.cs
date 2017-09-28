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
            
            
                
        public static async Task MainAsync(string Token, string renderDir, string animDir, ulong CID, bool render, bool animation, bool preview)
        {
            var discord = new DiscordClient(new DiscordConfiguration
            {
                Token = Token,
                TokenType = TokenType.Bot
            });
                DSharpPlus.Entities.DiscordChannel _channel = await discord.GetChannelAsync(CID);
            if (render)
            {
                long renderSize = new System.IO.FileInfo(renderDir).Length;
                if (preview)
                {
                    if (renderSize > 8000000)
                    {
                        await _channel.SendMessageAsync("Finished! Keep up the good work (preview image too large)!");
                    }
                    else
                    {
                        await _channel.SendFileAsync(renderDir, "Finished! Keep up the good work!");
                    }
                }
                else
                {
                    await _channel.SendMessageAsync("Finished! Keep up the good work!");
                }
            }
            if (animation)
            {

            }


            discord.SetWebSocketClient<WebSocketSharpClient>();
            await discord.ConnectAsync();
        }
    }
}
