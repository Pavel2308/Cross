namespace Cross.Model.Common
{
    public abstract class CancellationDbEntity : DbEntity, ICancellationDbEntity
    {
        public bool IsCancelled { get; set; }
    }
}
