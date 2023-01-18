namespace Metoura.Core.Entities;

public class User : BaseEntity
{
    public string Gender { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    public string PasswordHash { get; set; }

    public string HashSalt { get; set; }
}