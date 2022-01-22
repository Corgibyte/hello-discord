using Discord.Commands;

namespace HelloDiscord.Modules
{
  public class HelloModule : ModuleBase<SocketCommandContext>
  {
    //!say hello world -> hello world
    [Command("say")]
    [Summary("Echoes a message.")]
    public Task SayAsync([Remainder][Summary("The text to echo")] string echo) => ReplyAsync(echo);

    // ReplyAsync is a method on ModuleBase
  }
}