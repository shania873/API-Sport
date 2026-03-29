namespace Api_Sport.Models;

public class Appointment
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime DateTime { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
