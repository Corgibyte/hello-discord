using Discord.Commands;

namespace HelloDiscord.Modules
{
  [Group("say")]
  public class HelloModule : ModuleBase<SocketCommandContext>
  {
    //!say hello world -> hello world
    [Command("echo")]
    [Summary("Echoes a message.")]
    public Task SayAsync([Remainder][Summary("The text to echo")] string echo) => ReplyAsync(echo);

    [Command("slow", RunMode = RunMode.Async)]
    [Summary("Slowly echoes a message")]
    public async Task RepeatAsync([Remainder][Summary("The text to echo")] string echo)
    {
      await Task.Delay(TimeSpan.FromSeconds(10));
      await ReplyAsync(echo);
    }
  }
}