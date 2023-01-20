namespace Metoura.Core.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MiddleName { get; set; }

    public string Email { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string Address { get; set; }

    public string Gender { get; set; }

    public string PasswordHash { get; set; }

    public string HashSalt { get; set; }
}