namespace BusinessManagment.DomainLayer.Entity
{
    public class Inventory
    {
        public long InventoryId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SellingPrice { get; set; }
        public int? SellableStock { get; set; }
        public int? DamagedStock { get; set; }
        public long? ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public virtual ICollection<InventoryMovement> InventoryMovements { get; set; } = new List<InventoryMovement>();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}
