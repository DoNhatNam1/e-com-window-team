using System;
using EComWindowTeam.HomeMvc.Enums;

namespace EComWindowTeam.HomeMvc.Models
{
    public class TbOrder
    {
        public int id { get; set; }
        public string ConfigurationId { get; set; }
        public string UserId { get; set; }
        public float Amount { get; set; }
        public bool IsPaid { get; set; } = false;
        public OrderStatus Status { get; set; } = OrderStatus.awaiting_shipment;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime Updated { get; set; } = DateTime.UtcNow;

        // Foreign keys and navigation properties
        public TbConfiguration Configuration { get; set; }
        public TbUser User { get; set; }
        public string? ShippingAddressId { get; set; }
        public TbShippingAddress? ShippingAddress { get; set; }
        public TbTemporaryAddress? TemporaryAddress { get; set; }
        public ICollection<TbOrder> orders { get; set; }
    }
}