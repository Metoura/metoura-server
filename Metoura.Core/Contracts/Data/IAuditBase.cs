namespace Metoura.Core.Contracts.Data
{
    public interface IAuditBase
    {
        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}