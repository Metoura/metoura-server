using Metoura.Core.Contracts.Data;

namespace Metoura.Core.Entities;

public abstract class BaseEntity : ISoftDeletable, IAuditBase
{
    public Guid Id { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Modified { get; set; }

    public string CreatedBy { get; set; }

    public string ModifiedBy { get; set; }

    public byte[] RowVersion { get; set; }
}