namespace BusinessManagment.DomainLayer.Entity
{
    public class Order
    {
        public long OrderId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string? Status { get; set; }
        public string? PaymentStatus { get; set; }
        public decimal TotalAmt { get; set; }
        public string? Remark { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}
