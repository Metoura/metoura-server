namespace Metoura.Core.Contracts.Data;

public interface ISoftDeletable
{
    public bool IsDeleted { get; set; }
}