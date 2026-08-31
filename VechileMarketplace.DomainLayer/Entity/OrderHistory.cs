namespace BusinessManagment.DomainLayer.Entity
{
    public class OrderHistory
    {
        public long Id { get; set; }
        public string? Status { get; set; }
        public DateTime? ChangedAt { get; set; }
        public string? Remark { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
