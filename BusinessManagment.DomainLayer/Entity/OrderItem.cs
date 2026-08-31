using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManagment.DomainLayer.Entity
{
    public class OrderItem
    {
        public long OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal Subtotal { get; set; }
        public long OrderId { get; set; }
        public virtual Order Order { get; set; } = null!;
        public long ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
