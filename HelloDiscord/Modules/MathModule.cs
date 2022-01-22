using Discord.Commands;

namespace HelloDiscord.Modules
{
  //Create a module with the 'math' prefix
  [Group("math")]
  public class MathModule : ModuleBase<SocketCommandContext>
  {
    //!math square 20 -> 400
    [Command("square")]
    [Summary("Squares a number.")]
    public async Task SquareAsync
    (
      [Summary("The number to square.")]
      int num
    )
    {
      //We can also access the channel from the Command Context.
      await Context.Channel.SendMessageAsync($"{num}^2 = {Math.Pow(num, 2)}");
    }
  }
}