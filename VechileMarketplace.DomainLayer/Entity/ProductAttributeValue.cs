namespace BusinessManagment.DomainLayer.Entity
{
    public class ProductAttributeValue
    {
        public long PavId { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public long AttributeId { get; set; }
        public virtual AttributeDefinition AttributeDefinition { get; set; } = null!;
        public string? Values { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
