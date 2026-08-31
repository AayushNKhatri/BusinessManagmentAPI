namespace BusinessManagment.DomainLayer.Entity
{
    public class ProductType
    {
        public long ProductTypeId { get; set; }
        public string ProductTypeName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public virtual ICollection<AttributeDefinition> AttributeDefinitions { get; set; } = new List<AttributeDefinition>();
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}
