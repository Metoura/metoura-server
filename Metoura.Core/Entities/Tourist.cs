namespace Metoura.Core.Entities;

public class Tourist : BaseEntity
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MiddleName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; }

}