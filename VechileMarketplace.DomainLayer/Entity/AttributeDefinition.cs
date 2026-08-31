namespace BusinessManagment.DomainLayer.Entity
{
    public class AttributeDefinition
    {
        public long AttributeId { get; set; }
        public string AttributeDefinitionName { get; set; } = string.Empty;
        public string AttributeDataType { get; set; } = string.Empty;
        public bool IsRequeried { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public long ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; } = null!;
        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
