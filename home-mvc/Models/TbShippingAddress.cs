using System.Collections.Generic;

namespace EComWindowTeam.HomeMvc.Models
{
    public class TbShippingAddress
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string? State { get; set; }
        public string? PhoneNumber { get; set; }

        // Navigation property
        public ICollection<TbOrder> Orders { get; set; } = new List<TbOrder>();
    }
}