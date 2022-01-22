using Discord;
using Discord.WebSocket;

namespace HelloDiscord
{
  public class Program
  {
    public static Task Main(string[] args) => Startup.RunAsync(args);
  }
}