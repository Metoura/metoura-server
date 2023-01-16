namespace Metoura.Core.Entities;

public class Admin : BaseEntity
{
    public Guid UserId { get; set; }

    public User User { get; set; }

    public Guid RoleId { get; set; }

    public Role Role { get; set; }
}