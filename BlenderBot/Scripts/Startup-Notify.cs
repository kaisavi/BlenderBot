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
    {public static int attempts = 1;
        [STAThread]
        public static void Main(string[] args)
        {
            if (args.Length != 0)
            {
            if (args[0] == "-n" || args[0] == "--no-quit")
            {
                Forms.Animation.noquit = true;
                Forms.Render.noquit = true;
            }
            }
            else
            {
                Forms.Animation.noquit = false;
                Forms.Render.noquit = false;
            }

            var StartupForm = new StartupForm();
            Application.Run(StartupForm);
        }



        public static async Task MainAsync(string Token, string renderDir, string animDir, ulong CID, bool render, bool animation, bool preview, int Result, object args)
        {
            
            var discord = new DiscordClient(new DiscordConfiguration
            {
                Token = Token,
                TokenType = TokenType.Bot
            });
            
            DSharpPlus.Entities.DiscordChannel _channel = await discord.GetChannelAsync(CID);
            if (render)
            {
                if (Result == 0)
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
                else
                {
                    await _channel.SendMessageAsync($"Your render did not complete successfully (Exit code {Result}). Would you like to try again? (Y/N) *case sensitive*");

                }
            }


            if (animation)
            {

            }

            discord.MessageCreated += async e =>
            {
                string response = e.Message.Content.ToString();
                if (Result != 0)
                {
                    if (!e.Message.Author.IsBot)
                    {
                        switch (response)
                        {
                            case "Y":
                                await e.Message.RespondAsync("Trying again!");
                                Console.WriteLine(args.ToString());
                                attempts++;
                                Result = Start.Render(args);
                                break;
                            case "N":
                                await e.Message.RespondAsync("Quitting Blenderbot...");
                                Environment.Exit(0);
                                break;
                            default:
                                await e.Message.RespondAsync("What?");
                                break;
                        }
                        if (Result != 0)
                        {
                            await _channel.SendMessageAsync($"Your render did not complete successfully (Exit code {Result}). Would you like to try again (no. of attemps: {attempts})?");
                        } 
                    }



                }
            };

            discord.SetWebSocketClient<WebSocketSharpClient>();
            await discord.ConnectAsync();
        }
    }
}
