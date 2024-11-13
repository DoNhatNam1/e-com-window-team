namespace EComWindowTeam.HomeMvc.Models
{
    public class TbTemporaryAddress
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string? State { get; set; }

        // Foreign key and navigation property
        public int OrderId { get; set; }
        public TbOrder Order { get; set; }
    }
}