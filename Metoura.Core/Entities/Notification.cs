namespace Metoura.Core.Entities;

public class Notification : BaseEntity
{
    public Guid UserId { get; set; }

    public User User { get; set; }

    public string Message { get; set; }
}