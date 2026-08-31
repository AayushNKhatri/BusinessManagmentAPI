namespace BusinessManagment.DomainLayer.Entity
{
    public class InventoryMovement
    {
        public long InventoryMovementId { get; set; }
        public int QuantityChange { get; set; }
        public string? Reason { get; set; }
        public string? Remark { get; set; }
        public long InventoryId { get; set; }
        public virtual Inventory Inventory { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
