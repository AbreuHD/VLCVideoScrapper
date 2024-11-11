using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using Button = DiscordRPC.Button;
namespace App
{
    public static class RCP
    {
        private static DiscordRpcClient client;
        public static bool Active { get; set; } = true;

        static RCP()
        {
            Initialize();
        }

        private static void Initialize()
        {
            client = new DiscordRpcClient("1305384057386827846");

            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            client.OnError += (sender, e) =>
            {
                Console.WriteLine($"Error: {e.Message}");
            };

            client.Initialize();

        }

        public static void SetPresenceTxt(string tittle, string description, string img)
        {
            if (Active)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = tittle,
                    State = description,
                    Assets = new Assets()
                    {
                        LargeImageKey = img,
                        LargeImageText = img,
                        SmallImageKey = img,
                    },
                    Buttons = new Button[]
                    {
                        new Button(){ Label = "Download", Url = "https://github.com/AbreuHD/VLCVideoScrapper"}
                    },
                });
            }
        }
        public static void SetPresenceTime(string title, TimeSpan posicionActual, TimeSpan duracionTotal, string img)
        {
            if (Active)
            {
                var richPresence = new RichPresence()
                {
                    Details = title,
                    State = $"Progreso: {posicionActual:mm\\:ss} / {duracionTotal:mm\\:ss}",
                    Assets = new Assets()
                    {
                        LargeImageKey = "https://image.tmdb.org/t/p/original"+img,
                        LargeImageText = title,
                        SmallImageKey = "https://image.tmdb.org/t/p/original"+img,
                    },
                    Timestamps = new Timestamps
                    {
                        Start = DateTime.UtcNow - posicionActual,
                        End = DateTime.UtcNow + (duracionTotal - posicionActual)
                    },
                    Buttons = new Button[]
                    {
                        new Button(){ Label = "Download", Url = "https://github.com/AbreuHD/VLCVideoScrapper"}
                    },
                };
                client.SetPresence(richPresence);
            }
        }

        public static void Dispose()
        {
            client.Dispose();
        } 

        public static void ClearPresence()
        {
            client.ClearPresence();
        }

    }
}
