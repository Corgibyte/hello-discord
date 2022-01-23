namespace HelloDiscord.Models
{
  public class Event
  {
    public int EventId { get; set; }
    public DateTime EventDateTime { get; set; }
    public bool HasFired { get; set; }
    public Event(DateTime eventDateTime)
    {
      EventDateTime = eventDateTime;
      HasFired = false;
    }
  }
}